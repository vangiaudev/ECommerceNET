using ECommerceNET.Entities;
using ECommerceNET.MailMessenger;
using ECommerceNET.Models;
using ECommerceNET.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using BraintreeHttp;
using System.Web;

using Microsoft.AspNetCore.Http.Features;
//using PayPal;
//using PayPal.Api;

using PayPalCheckoutSdk.Core;
using PayPalCheckoutSdk.Payments;
using PayPalCheckoutSdk.Orders;
//using PayPalCheckoutSdk.Core;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading;
using System.Threading.Tasks;
using log4net;
using System.Net;

namespace ECommerceNET.Controllers
{
    public class GioHangController : Controller
    {
        public IActionResult Index()
        {

            if (ssuser != null)
            {
                ViewBag.houser = ssuser.hoUser;
                ViewBag.tenuser = ssuser.tenUser;
                ViewBag.accmenu1 = "Thông tin cá nhân";
                ViewBag.accmenu2 = "Đơn mua";
                ViewBag.accmenu3 = "Thoát";
                if (ssuser.vaitro == "admin")
                {
                    ViewBag.accmenu4 = "Trang quản trị";
                }
                else if (ssuser.vaitro == "staff")
                {
                    ViewBag.accmenu4 = "Trang nhân viên";
                }
            }
            else
            {
                ViewBag.houser = "TÀI";
                ViewBag.tenuser = "KHOẢN";
                ViewBag.accmenu1 = "Đăng nhập";
            }
         //   string a = SlugGenerator.SlugGenerator.GenerateSlug("1532");
            return View(Carts);
        }

        public IActionResult AddTocart(int id,int sl)
        {
            
            if (sl == 0) { sl = 1; }
            var mycart = Carts;
            var item = mycart.SingleOrDefault(p => p.idSP == id);

            if (item == null)
            {
                var sp = _context.SanPhams.SingleOrDefault(p => p.idSP == id);
                item = new SSGioHang
                {

                    idSP = id,
                    tensp = sp.tenSP,
                    hinhAnh = sp.hinhAnh,
                    giasp = sp.giaSP,
                    soLuong = sl,
                };

                mycart.Add(item);
            }
            else
            {
                item.soLuong+=sl;
            }

            HttpContext.Session.Set("GioHang", mycart);
            return RedirectToAction("Index");
        }

        private readonly MyDBContext _context;
        private readonly string _clientID;
        private readonly string _secretKey;
        private readonly string _codeVNPAY;
        private readonly string _secretKeyVNPAY;
        public double tyGiaUSD = 23000;

        public GioHangController(MyDBContext context,IConfiguration config)
        {
            _context = context;
            _clientID = config["PaypalSettings:ClientID"];
            _secretKey = config["PaypalSettings:SecretKey"];
            _codeVNPAY = config["VNPaySettings:TmnCode"];
            _secretKeyVNPAY = config["VNPaySettings:SecretKey"];
        }

        public List<SSGioHang> Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<SSGioHang>>("GioHang");
                if (data == null)
                {
                    data = new List<SSGioHang>();
                }
                return data;
            }
        }


        public sessionuser ssuser
        {
            get
            {
                var data = HttpContext.Session.Get<sessionuser>("ssuser");
                /* if (data == null)
                 {
                     data = new sessionuser();
                 }*/
                return data;
            }
        }

        public ssdonhangpaypal ssdatapaypal
        {
            get
            {
                var data = HttpContext.Session.Get<ssdonhangpaypal>("datapaypal");
                /* if (data == null)
                 {
                     data = new sessionuser();
                 }*/
                return data;
            }
        }

        [HttpPost]
        public IActionResult AddTocartAjax(int id, int sl)
        {

            if (sl == 0) { sl = 1; }
            var mycart = Carts;
            var item = mycart.SingleOrDefault(p => p.idSP == id);

            if (item == null)
            {
                var sp = _context.SanPhams.SingleOrDefault(p => p.idSP == id);
                item = new SSGioHang
                {

                    idSP = id,
                    tensp = sp.tenSP,
                    hinhAnh = sp.hinhAnh,
                    giasp = sp.giaSP,
                    soLuong = sl,
                };

                mycart.Add(item);
            }
            else
            {
                item.soLuong += sl;
            }

            HttpContext.Session.Set("GioHang", mycart);
            return View();
        }

      [HttpPost]
        public IActionResult checkmgg(string id)
        {
            var mgg = _context.MaGiamGias
                .FirstOrDefault(p => p.codeMGG == id);

            if (mgg == null || mgg.soLuong<=0 || mgg.trangThai=="Ẩn") {
                ViewBag.mess = "-1";
            }
            else
            {
                ViewBag.mess = mgg.giaTri;

            }


        
            return View();       
        }

        [HttpPost]
        public IActionResult tongtien()
        {

            ViewBag.mess = Carts.Sum(p => p.thanhTien);


            return View();
        }


        public IActionResult checkout(int mggvl,string mggvlcode, int tth, int tongcong)
        {

            if (Carts.Count==0)
            {
                RedirectToAction("index", "giohang");
            }
        
            if (ssuser != null)
            {
                ViewBag.houser = ssuser.hoUser;
                ViewBag.tenuser = ssuser.tenUser;
                ViewBag.accmenu1 = "Thông tin cá nhân";
                ViewBag.accmenu2 = "Đơn mua";
                ViewBag.accmenu3 = "Thoát";
                if (ssuser.vaitro == "admin")
                {
                    ViewBag.accmenu4 = "Trang quản trị";
                }
                else if (ssuser.vaitro == "staff")
                {
                    ViewBag.accmenu4 = "Trang nhân viên";
                }
            }
            else
            {
                ViewBag.houser = "TÀI";
                ViewBag.tenuser = "KHOẢN";
                ViewBag.accmenu1 = "Đăng nhập";
            }
            ViewBag.mggvlcode = mggvlcode;
            ViewBag.mggvl = mggvl;
            ViewBag.tth = tth;
            ViewBag.tongcong = tongcong;
            if (ssuser != null)
            {
  ViewBag.ho = ssuser.hoUser;
            ViewBag.ten = ssuser.tenUser;
            ViewBag.email = ssuser.emailUser;
            ViewBag.sdt = ssuser.sdtUser;
            ViewBag.diachi = ssuser.diaChi;
            }
          


            return View();
        }



        public IActionResult xacnhancheckout(string id,int mggvl,string mggvlcode, int tth, int tongcong, string ho, string ten, string diachi, string email,string sdt, string ghichu , string howpay)
        {
            if (id != null && id != "")
            {
                var temp = ssdatapaypal;
                 mggvl= temp.mggvl ;
                mggvlcode = temp.mggvlcode;
                tth = temp.tth;
                tongcong = temp.tongcong;
                ho = temp.ho;
                ten = temp.ten;
                diachi = temp.diachi;
                email = temp.email;
                sdt = temp.sdt;
                ghichu = temp.ghichu;


            }

            if (ssuser != null)
            {
                ViewBag.houser = ssuser.hoUser;
                ViewBag.tenuser = ssuser.tenUser;
                ViewBag.accmenu1 = "Thông tin cá nhân";
                ViewBag.accmenu2 = "Đơn mua";
                ViewBag.accmenu3 = "Thoát";
                if (ssuser.vaitro == "admin")
                {
                    ViewBag.accmenu4 = "Trang quản trị";
                }
                else if (ssuser.vaitro == "staff")
                {
                    ViewBag.accmenu4 = "Trang nhân viên";
                }
            }
            else
            {
                ViewBag.houser = "TÀI";
                ViewBag.tenuser = "KHOẢN";
                ViewBag.accmenu1 = "Đăng nhập";
            }

            if (sdt == null ||email==null)
            {
                return RedirectToAction("index", "giohang");
            }
            var mggcode = _context.MaGiamGias.FirstOrDefault(p => p.codeMGG == mggvlcode);

            if (mggcode != null)
            {
                mggcode.soLuong--;
                _context.Update(mggcode);
                _context.SaveChanges();
            }



            var db  = _context.DonHangs
                //      .Where(p => p.luotMua > 100)              // Lọc các sản phẩm giá trên 100
                .OrderByDescending(p => p.idDH)        // Sắp xếp giảm dần, tăng dần là OrderBy
                .Take(1); ;


            
            DateTime xx = DateTime.Now;
            
            DonHang dh = new DonHang();
          if (ssuser != null)
            {
                dh.idUser = ssuser.idUser;
            }
            dh.trangThai = "Đang xử lý";
            dh.ngayCapNhat = xx;
            dh.ngayDat = xx;
            dh.hoDH = ho;
            dh.tenDH = ten;
            dh.sdtDH = sdt;
            dh.diaChi = diachi;
            dh.eMail = email;
            dh.ghiChu = ghichu;
            dh.tongTienHang = tth;
            dh.tongSoTien = tongcong;
            dh.maGiamGiaDH = mggvl;
            int x;
            if (id != "" && id != null)
            {
                //  dh.idDH = Int32.Parse(id);
                

                if (howpay == "vnpay")
                {
                    dh.ghiChu = ghichu + " - Mã giao dịch VNPAY: " + id;
                    dh.trangThai = "Đã thanh toán qua VNPay, chờ giao hàng";
                }
                else
                {
                    dh.ghiChu = ghichu + " - Mã hóa đơn thanh toán Paypal: " + id;


                    dh.trangThai = "Đã thanh toán qua PayPal, chờ giao hàng";
                }
                 x = insert(dh);
            }
            else
            {


                 x = insert(dh);
            }

            

           

            foreach (var item in Carts)
            {
                ChiTietDonHang xxx = new ChiTietDonHang();

                xxx.idDH = x;
                xxx.tenSP = item.tensp;
                xxx.hinhSP = item.hinhAnh;
                xxx.donGia = item.giasp;
                xxx.soLuong = item.soLuong;
                xxx.thanhTien = item.thanhTien;
                

                _context.Add(xxx);
                _context.SaveChanges();

                var ct = _context.SanPhams
                    .FirstOrDefault(p => p.idSP == item.idSP);
                ct.luotMua++;
                ct.soLuongKho--;

                _context.Update(ct);
                _context.SaveChanges();
            }




            var ss = new List<SSGioHang>();

                HttpContext.Session.Set("GioHang", ss);
            if (ssuser == null)
            {
ViewBag.mess = "Đặt hàng thành công! Bạn có thể dùng mã này để tra cứu trạng thái đơn hàng: " + x;
            }
            else
            {
                ViewBag.mess = "Đặt hàng thành công!";
            }

            var sss = new ssdonhangpaypal();

            HttpContext.Session.Set("datapaypal", sss);

            ViewBag.iddh = x;
            ViewBag.emails = email;

            /*
                        ViewBag.mess=x;
                        return View();*/
            return View();
        }

     


            public int insert(DonHang dh)
        {
            _context.Add(dh);
            _context.SaveChanges();
            return dh.idDH;
        }


        public IActionResult hoanthanh(int xx)
        {



            //var db = _context.DonHangs.FirstOrDefault(p => p.ngayDat == xx);

            /*  foreach (var item in Carts)
              {
                  ChiTietDonHang xxx = new ChiTietDonHang();

                  xxx.idDH = xx;
                  xxx.tenSP = item.tensp;
                  xxx.hinhSP = item.hinhAnh;
                  xxx.donGia = item.giasp;
                  xxx.soLuong = item.soLuong;
                  xxx.thanhTien = item.thanhTien;
                  _context.Add(xxx);
                  await _context.SaveChangesAsync();

              }


              Carts.Clear();

              HttpContext.Session.Set("GioHang", Carts);*/
            ViewBag.mess = xx;

            return View();
          //  return RedirectToAction("index", "giohang");
        }




        public IActionResult xoasp(int? id)
        {
            var data = Carts;

            var item = data.SingleOrDefault(p => p.idSP == id);
            data.Remove(item);
            HttpContext.Session.Set("GioHang", data);

            return RedirectToAction("index", "giohang");
        }

        string rdtextfail = "";

        public void setRD(string s)
        {
            rdtextfail = s;
        }

        public async System.Threading.Tasks.Task<IActionResult> payPalCheckOut(int mggvl, string mggvlcode, int tth, int tongcong, string ho, string ten, string diachi, string email, string sdt, string ghichu)
        {
            var data = new ssdonhangpaypal
            {
                ho = ho,
                mggvl =mggvl,
                mggvlcode = mggvlcode,
                tth=tth,
                tongcong=tongcong,
                ten=ten,
                diachi=diachi,
                email=email,
                sdt=sdt,
                ghichu=ghichu,
            };
            HttpContext.Session.Set("datapaypal", data);
            // string a = name;
            //   a = s;
            var environment = new SandboxEnvironment(_clientID, _secretKey);
         //   var client = new PayPalHttpClient(environment);

            #region Create payment (just example)
            /* var itemList = new ItemList()
             {
                 items = new List<PayPal.Api.Item>()
             };*/
            var itemList = new List<PayPalCheckoutSdk.Orders.Item>();
            double total2 = 0;
            var total = Math.Round(Carts.Sum(p => p.thanhTien) / tyGiaUSD, 2);
            foreach (var item in Carts)
            {
                /*itemList.items.Add(new PayPal.Api.Item()
                {
                    name = item.tensp,
                    currency = "USD",
                    price = Math.Round(item.giasp / tyGiaUSD, 2).ToString(),
                    quantity = item.soLuong.ToString(),
                    sku = "sku",
                    tax = "0"
                });*/
                total2 = total2 + Math.Round(item.giasp / tyGiaUSD, 2) * item.soLuong;

                itemList.Add(
                    new PayPalCheckoutSdk.Orders.Item
                    {
                        Name = item.tensp,
                        Sku = "sku",
                        Tax = new PayPalCheckoutSdk.Orders.Money
                        {
                            CurrencyCode = "USD",
                            Value = "0"
                        },
                        Quantity = item.soLuong.ToString(),
                        UnitAmount =
                            new PayPalCheckoutSdk.Orders.Money
                            {
                                CurrencyCode = "USD",
                                Value = Math.Round(item.giasp / tyGiaUSD, 2).ToString()
                            }
                    }
                    );
            }

            total2 = Math.Round(total2, 2);
            #endregion

            //var payPalOderId = DateTime.Now.Ticks;
            //int j = 1;
            
            

            var hostname = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
            Random random = new Random();
            string rd1 = random.Next(10000, 99999).ToString();
            string rd = random.Next(1000, 9999).ToString();
            rdtextfail = rd1 + rd;
            setRD(rdtextfail);
            OrderRequest payment = new OrderRequest()
            {
                CheckoutPaymentIntent = "CAPTURE",
                PurchaseUnits = new List<PurchaseUnitRequest>
                {
                    new PurchaseUnitRequest
                    {
                        AmountWithBreakdown = new AmountWithBreakdown
                        {
                            Value = total2.ToString(),
                            CurrencyCode = "USD",

                            AmountBreakdown = new AmountBreakdown
                            {
                                TaxTotal = tinhtien("0") ,
                                Shipping = tinhtien("0"),
                                //shipping_discount="0",
                                //subtotal = "0",
                                ItemTotal = new PayPalCheckoutSdk.Orders.Money
                                {
                                    CurrencyCode = "USD",
                                    Value = total2.ToString(),
                                },
                            }
                        },
                        Items = itemList,
                        ReferenceId =  rd1 + rd,
                        Description = "Invoice #" + rd1 + rd,
                        CustomId = "CUST-HighFashions"


                        //item_list = itemList,
                        //description = ,
                        //invoice_number = ,
                        
                    }

                },
                ApplicationContext = new ApplicationContext
                {
                    BrandName = "YAN Store INC",
                    LandingPage = "BILLING",
                    UserAction = "CONTINUE",
                   // ShippingPreference = $"{hostname}/GioHang/xacnhancheckout/",
                    CancelUrl = $"{hostname}/GioHang/CheckOutFail/"+rdtextfail,
                    ReturnUrl= $"{hostname}/GioHang/xacnhancheckout/"+rdtextfail,
                   // PaymentMethod = new PaymentMethod
                   // {
                   //     PayeePreferred = "paypal",
                   //     PayerSelected = "paypal"
                   // },
                },

                
                
            };
            //var response = await ExecutePayPalRequest(paypalHttpClient, request);
            //OrdersCreateRequest request = new OrdersCreateRequest();
            // request.RequestBody(payment);

            // var request = new OrdersCreateRequest();

            //   request.Prefer("return=representation");



            // request.RequestBody(payment);

          //  await CreateOrder(payment);


            var request = new OrdersCreateRequest();
            request.Prefer("return=representation");
            request.RequestBody(payment);
            var response = await PayPalClient.client().Execute(request);

            try
            {

                //var response = await client.;

                //  var result = response.Result<Payment>();

                var result = response.Result<Order>();
                var OderId = result.Id;
                var statusCode = result.Status;
                //   Console.WriteLine("Status: {0}", );
                //  Console.WriteLine("Order Id: {0}", );
                // Console.WriteLine("Intent: {0}", );
                var Intent = result.CheckoutPaymentIntent;
                //    Console.WriteLine("Links:");
                //    foreach (PayPalCheckoutSdk.Orders.LinkDescription link in result.Links)
                //   {
                //       Console.WriteLine("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
                //  }
              //  var links = result.Links.GetEnumerator();
                string Paypalred = null;
                foreach (PayPalCheckoutSdk.Orders.LinkDescription link in result.Links)
                {
                    if (link.Rel.ToLower().Trim().Equals("approve"))
                    {
                        Paypalred = link.Href;
                    }
                }    
                    AmountWithBreakdown amount = result.PurchaseUnits[0].AmountWithBreakdown;
                //  Console.WriteLine("Total Amount: {0} {1}", , );
                var totalamount = amount.CurrencyCode + " " + amount.Value;
                return Redirect(Paypalred);
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();
                return Redirect("/GioHang/CheckOutFail/"+rdtextfail);

            }



            ///return View();
        }

        


        PayPalCheckoutSdk.Orders.Money tinhtien(string value)
        {
            PayPalCheckoutSdk.Orders.Money x = new PayPalCheckoutSdk.Orders.Money();
            x.CurrencyCode = "USD";
            x.Value = value;
            return x;
        }
        

        public IActionResult CheckOutFail(string id)
        {
            
            if (id==null || id == "" || ssdatapaypal ==null)
            {
                return RedirectToAction("index", "GioHang");
            }
            var ss = new ssdonhangpaypal();

            HttpContext.Session.Set("datapaypal", ss);
            ViewBag.text = id;
            //rdtextfail = "";
            return View();
        }

        private static readonly ILog log =
          LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IActionResult VNPayCheckOut(int mggvl, string mggvlcode, int tth, int tongcong, string ho, string ten, string diachi, string email, string sdt, string ghichu)
        {
            var data = new ssdonhangpaypal
            {
                ho = ho,
                mggvl = mggvl,
                mggvlcode = mggvlcode,
                tth = tth,
                tongcong = tongcong,
                ten = ten,
                diachi = diachi,
                email = email,
                sdt = sdt,
                ghichu = ghichu,
            };
            HttpContext.Session.Set("datapaypal", data);
            // string a = name;
            //   a = s;
            var hostname = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";

            IPHostEntry iPHostEntry = Dns.GetHostEntry(Dns.GetHostName());
            string ipaddress = Convert.ToString(iPHostEntry.AddressList.FirstOrDefault(add => add.AddressFamily==System.Net.Sockets.AddressFamily.InterNetwork));


            Random random = new Random();
            string rd1 = random.Next(10000, 99999).ToString();
            string rd = random.Next(1000, 9999).ToString();
            rdtextfail = rd1 + rd;
            setRD(rdtextfail);
            //Get Config Info
            string vnp_Returnurl = hostname + "/GioHang/IPNURLVNPAY/"; //URL nhan ket qua tra ve 
            string vnp_Url = "http://sandbox.vnpayment.vn/paymentv2/vpcpay.html"; //URL thanh toan cua VNPAY 
            string vnp_TmnCode = _codeVNPAY; //Ma website
            string vnp_HashSecret = _secretKeyVNPAY; //Chuoi bi mat

            string dec = "";
            

            foreach (var item in Carts)
            {
                /*itemList.items.Add(new PayPal.Api.Item()
                {
                    name = item.tensp,
                    currency = "USD",
                    price = Math.Round(item.giasp / tyGiaUSD, 2).ToString(),
                    quantity = item.soLuong.ToString(),
                    sku = "sku",
                    tax = "0"
                });*/
                

                dec = dec + item.soLuong.ToString() + " x " + item.tensp + "[Đơn giá: " + item.giasp.ToString() + "] ; \n";
                
                      
            }


            //Get payment input
            OrderInfo order = new OrderInfo();
            //Save order to db
            order.OrderId = DateTime.Now.Ticks;
            order.Amount = tongcong*100;
            order.OrderDescription = dec;
            order.CreatedDate = DateTime.Now;
            string locale = "vn";
            //Build URL for VNPAY
            VnPayLibrary vnpay = new VnPayLibrary();

            vnpay.AddRequestData("vnp_Version", "2.0.0");
            vnpay.AddRequestData("vnp_Command", "pay");
            vnpay.AddRequestData("vnp_TmnCode", vnp_TmnCode);
            vnpay.AddRequestData("vnp_Amount", order.Amount.ToString());
            
            vnpay.AddRequestData("vnp_CreateDate", order.CreatedDate.ToString("yyyyMMddHHmmss"));
            vnpay.AddRequestData("vnp_CurrCode", "VND");
            vnpay.AddRequestData("vnp_IpAddr", ipaddress);


            if (!string.IsNullOrEmpty(locale))
            {
                vnpay.AddRequestData("vnp_Locale", locale);
            }
            else
            {
                vnpay.AddRequestData("vnp_Locale", "vn");
            }
            vnpay.AddRequestData("vnp_OrderInfo", order.OrderDescription);
            vnpay.AddRequestData("vnp_OrderType", "other"); //default value: other
            vnpay.AddRequestData("vnp_ReturnUrl", vnp_Returnurl);
            vnpay.AddRequestData("vnp_TxnRef", order.OrderId.ToString());

            string paymentUrl = vnpay.CreateRequestUrl(vnp_Url, vnp_HashSecret);
         //   log.InfoFormat("VNPAY URL: {0}", paymentUrl);
            Response.Redirect(paymentUrl);


            //   var client = new PayPalHttpClient(environment);



            return View();
        }


        public IActionResult IPNURLVNPAY(string vnp_ResponseCode , string vnp_TransactionNo)
        {
            
            
                string vnp_HashSecret = _secretKeyVNPAY; //Secret key
                var vnpayData = Request.QueryString;
                
                //Lay danh sach tham so tra ve tu VNPAY
                //vnp_TxnRef: Ma don hang merchant gui VNPAY tai command=pay    
                //vnp_TransactionNo: Ma GD tai he thong VNPAY
                //vnp_ResponseCode:Response code from VNPAY: 00: Thanh cong, Khac 00: Xem tai lieu
                //vnp_SecureHash: SHA256 cua du lieu tra ve

                
                if (vnp_ResponseCode == "00")
                {
                    return Redirect("/giohang/xacnhancheckout/" + vnp_TransactionNo + "?howpay=vnpay");
                }

            else
            {
                return Redirect("/giohang/CheckOutFail/VNPay"  );
            }
            

            
        }


    }
}
