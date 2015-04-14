function Login() {
    var name = $("#name").val();
    var password = $("#password").val();
    var password2 = $("#password2").val();

    $.post("/Account/DoLogin", { "name": name, "password": password, "password2": password2 },
    function (data) {
        if (data == "0") {
            alert("登录失败");
        }
        else {
            alert("登录成功");
            window.location.href = "/Home/Index";
        }
    });
}

function Register() {
    var name = $("#name").val();
    var password = $("#password").val();
    var password2 = $("#password2").val();
    var code = $("code").val();

    $.post("/Account/DoRegister", { "name": name, "password": password, "password2": password2, "code": code },
    function (data) {
        if (data == "-1") {
            alert("验证码错误");
        }
        else if (data == "0") {
            alert("注册失败");
        }
        else {
            alert("注册成功");
            window.location.href = "/Account/Login";
        }
    });
}