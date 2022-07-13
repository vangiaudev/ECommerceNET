// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

(function ($) {
    $(document).ready(function () {
        $.ajax({
            url: "/LoaiSP/LoaiTTNam/",
            type:"POST",
            success: function (data) {
                $("#loadloaimenuTTNam").html(data);
            },


        });

        $.ajax({
            url: "/user/hoatdong/",
            type: "POST",
           


        });

        $.ajax({
            url: "/sanpham/sanphamnoibat/",
            type: "POST",
            success: function (data) {
                $("#dsspnoibat").html(data);
            },


        });

        $.ajax({
            url: "/Sanpham/sanphambanchay/",
            type: "POST",
            success: function (data) {
                $("#dsspbanchay").html(data);
            },


        });



        $.ajax({
            url: "/Sanpham/sanphammoi/",
            type: "POST",
            success: function (data) {
                $("#dsspmoi").html(data);
            },


        });

        $.ajax({
            url: "/Banner/index/",
            type:"POST",
            success: function (data) {
                $("#loaditembanner").html(data);
            },


        });

        $.ajax({
            url: "/LoaiSP/LoaiTTNu/",
            type:"POST",
            success: function (data) {
                $("#loadloaimenuTTNu").html(data);
            },


        });

        $("#paypalcheckout").click(function () {
            window.location = "/giohang/payPalCheckOut?mggvl=" + $("#mggvl").val() + "&mggvlcode=" + $("#mggvlcode").val() + "&tth=" + $("#tth").val() + "&tongcong=" + $("#tongcong").val() + "&ho=" + $("#ho").val() + "&ten=" + $("#ten").val() + "&diachi=" + $("#diachi").val() + "&email=" + $("#email").val() + "&sdt=" + $("#sdt").val() + "&ghichu=" + $("#ghichu").val();
        });

        $("#vnpaycheckout").click(function () {
            window.location = "/giohang/VNPayCheckOut?mggvl=" + $("#mggvl").val() + "&mggvlcode=" + $("#mggvlcode").val() + "&tth=" + $("#tth").val() + "&tongcong=" + $("#tongcong").val() + "&ho=" + $("#ho").val() + "&ten=" + $("#ten").val() + "&diachi=" + $("#diachi").val() + "&email=" + $("#email").val() + "&sdt=" + $("#sdt").val() + "&ghichu=" + $("#ghichu").val();
        });

        $("#timkiemdssp").keyup(function () {
            $.ajax({
                url: "/Sanpham/TimAjax/",
                data: {
                    keyword: $("#timkiemdssp").val().trim(),
                    kw2: $("#dssp2").val().trim(),
                    kw3: $("#dssp3").val().trim(),
                    idloai: $("#idloaidssp").val().trim(),
                },
                type: "POST",
                success: function (data) {
                    $("#kquadssp").html(data);
                }
            });
        });



        $("#submitlh").click(function () {
            $.ajax({
                url: "/Lienhe/indexadd/",
                data: {
                    hoten: $("#hotenlh").val().trim(),
                    email: $("#emaillh").val().trim(),
                    tieude: $("#tieudelh").val().trim(),
                    noidung: $("#noidunglh").val().trim(),
                },
                type: "POST",
                success: function (data) {
                   
                }
            });
        });



        $("#submitup1").click(function () {
            $.ajax({
                url: "/user/ttin/",
                data: {
                    ho: $("#hoacc").val().trim(),
                    ten: $("#tenacc").val().trim(),
                    email: $("#emailacc").val().trim(),
                    sdt: $("#sdtacc").val().trim(),
                    dchi: $("#addacc").val().trim(),
                },
                type: "POST",
                success: function (data) {
                    $("#kqua1").html(data);
                    
                }
            });
        });

        $.ajax({
            url: "/giohang/tongtien/",
            data: {
               
            },
            type: "POST",
            success: function (data) {
                $("#tth1").html(data+" đ");
                $("#tth").attr("value", data);

                $("#tongcong1").html(data+ " đ");
                $("#tongcong").attr("value", data);

            }

        }); 





        $("#checkmgg").click(function () {
            $.ajax({
                url: "/giohang/checkmgg/",
                data: {
                    id: $("#vlmgg").val().trim(), 
                },
                type: "POST",
                success: function (data) {
                    if (data == "-1") {
                        $("#kquamgg").html("Mã giảm giá không tồn tại");
                    }
                    else {
                        $("#kquamgg").html("");
                        $("#mgg1").html(data + " đ");
                        $("#mggvl").attr("value", data);

                        var tong = $("#tth").val()- $("#mggvl").val();
                        if (tong < 0) {
                            tong = 0;
                        }
                        $("#mggvlcode").attr("value", $("#vlmgg").val())
                       $("#tongcong1").html(tong+ " đ");
                        $("#tongcong").attr("value", tong);
                    }

                }
            });
        });


        




        $(".ajax-add-cart").click(function () {
            $.ajax({
                url: "/giohang/AddTocartAjax/",
                data: {
                    id: $(this).data("id"),
                    sl: $("#slx").val().trim(),
                    
                },
                type: "POST",
                success: function () {
                    Swal.fire({
                      //  position: 'top-end',
                        icon: 'success',
                        title: 'Thêm vào giỏ hàng thành công',
                        showConfirmButton: false,
                        timer: 1500
                    })

                  

                }
            });
        });
    

        




        $("#submitup2").click(function () {
            if ($("#newpw").val() != $("#repw").val()) {
                $("#kqua2").html("Mật khẩu không trùng khớp!");
            }
            else {
$.ajax({
                url: "/user/mkhau/",
                data: {
                    pw: $("#pw").val().trim(),
                    newpw: $("#newpw").val().trim(),
             
                },
                type: "POST",
                success: function (data) {
                    $("#kqua2").html(data);

                }
            });
            }
            
        });


        $("#tka").click(function () {
            window.location = "/sanpham/timkiem/" + $("#timkiemmain").val();
        });

        $("#dssp2").change(function () {
            $.ajax({
                url: "/Sanpham/TimAjax/",
                data: {
                    keyword: $("#timkiemdssp").val().trim(),
                    kw2: $("#dssp2").val().trim(),
                    kw3: $("#dssp3").val().trim(),
                    idloai: $("#idloaidssp").val().trim(),
                },
                type: "POST",
                success: function (data) {
                    $("#kquadssp").html(data);
                }
            });
        });

        $("#dssp3").change(function () {
            $.ajax({
                url: "/Sanpham/TimAjax/",
                data: {
                    keyword: $("#timkiemdssp").val().trim(),
                    kw2: $("#dssp2").val().trim(),
                    kw3: $("#dssp3").val().trim(),
                    idloai: $("#idloaidssp").val().trim(),
                },
                type: "POST",
                success: function (data) {
                    $("#kquadssp").html(data);
                }
            });
        });



        $("#tracuu").click(function () {
            window.location = "/Donhang/tracuu/" + $("#tracuudonhang").val();
        });


        $("#dangkyemail").click(function () {
            debugger;
            //var s = $("#dangkynhanthongtinemail").val();

            $.ajax({
                url: "https://gmail.us6.list-manage.com/subscribe/post?u=e985fec1fcfae851c88847638&amp;id=86ba2c5e1b",
                data: {
                    EMAIL: $("#dangkynhanthongtinemail").val(),
                    b_e985fec1fcfae851c88847638_86ba2c5e1b:""
                },
                type: "POST",
                success: function () {
                    Swal.fire({
                        position: 'center',
                        icon: 'success',
                        title: 'Đăng ký nhận tin qua email thành công',
                        showConfirmButton: false,
                        timer: 1500
                    })
                }
            });

            Swal.fire({
                position: 'center',
                icon: 'success',
                title: 'Đăng ký nhận tin qua email thành công',
                showConfirmButton: false,
                timer: 1500
            })
           // window.location = "/Donhang/tracuu/" + $("#tracuudonhang").val();
        });

        

        $("#submitlogin").click(function () {

            if ($("#emaillogin").val() == "" || $("#mkhaulogin").val() == "") {
                $("#kqua").html("Bạn chưa nhập đầy đủ thông tin!");
            }
            else {
                var x = navigator.appVersion;
             
              
             
                $.ajax({
                    url: "/Login/Verify/",
                    data: {
                        email: $("#emaillogin").val().trim(),
                        mkhau: $("#mkhaulogin").val().trim(),
                  
                        x: x,
                    },
                    type: "POST",
                    success: function (data) {
                        if (data == "users") {
                            window.location = "/Home/";
                        }
                        else if (data == "admins") {
                            window.location = "/Admin/HomeAdmin"
                        }
                        else if (data == "staffs") {
                            window.location = "/Staffs/HomeStaffs"
                        }
                        else if (data == "sendmail") {
                            window.location = "/Sendmail/index/"
                        }
                        else {
                            $("#kqua").html(data);

                        }

                    },
                });
            }


        });


        function checkDate(strDate) {
            var comp = strDate.split('/')
            var d = parseInt(comp[0], 10)
            var m = parseInt(comp[1], 10)
            var y = parseInt(comp[2], 10)
            var date = new Date(y, m - 1, d);
            if (date.getFullYear() == y && date.getMonth() + 1 == m && date.getDate() == d) {
                return true
            }
            return false
        }
        function checkEmail(email) {
     
            var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
            if (!filter.test(email)) {
                alert('Hay nhap dia chi email hop le.\nExample@gmail.com');
         
                return false;
            }
            else {
                return true;
                alert('OK roi day, Email nay hop le.');
            }
        }
        $("#dky").click(function () {
            if ($("#houser").val() == "" || $("#tenuser").val() == "" || $("#emailuser").val() == "" || $("#sdtuser").val() == "" || $("#pwuser").val() == "" || $("#repwuser").val() == "") {
                $("#kqua2").html("Chưa điền đầy đủ thông tin!")
            }
            else {
               
                  
                   
                        var str3 = $('#emailuser').val();
                if (!checkEmail(str3)) {
                    $("#kqua2").html("Email không hợp lệ!");
                }
                else {
                    if ($("#pwuser").val() != $("#repwuser").val()) {
                        $("#kqua2").html("Mật khẩu không trùng khớp!");
                    }
                    else {
                        var x = navigator.appVersion;
                   
                                    $.ajax({
                                        url: "/Login/Signup",
                                        data: {
                                            emailuser: $("#emailuser").val().trim(),
                                            pwuser: $("#pwuser").val().trim(),
                                            houser: $("#houser").val().trim(),
                                            tenuser: $("#tenuser").val().trim(),
                                            sdtuser: $("#sdtuser").val().trim(),
                                            gioiTinh: $("#gioiTinh").val().trim(),
                                            ngaysinh: $("#ngaysinh").val().trim(),
                                            thangsinh: $("#thangsinh").val().trim(),
                                            namsinh: $("#namsinh").val().trim(),
                                            x: x,
                                        },
                                        type: "POST",
                                        success: function (data) {
                                            if (data == "1") {
                                                $("#kqua2").html("Tài khoản đã tồn tại, vui lòng đăng nhập!");
                                            }
                                            else {
                                                window.location = "/Sendmail/";

                                            }

                                        },
                                    });
            
                    }

                }
                          
                                    
           
                                
                        }

                    
                




            
        });

    });

})(jQuery); // End of use strict
