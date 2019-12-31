@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated
    @Using Html.BeginForm("خروج", "Account", FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})
        @Html.AntiForgeryToken()
        @<ul class="nav navbar-nav navbar-right">
            <li>
                @Html.ActionLink("Hello " + User.Identity.GetUserName() + "!", "Index", "Manage", routeValues:=Nothing, htmlAttributes:=New With {.title = "Manage"})
            </li>
            <li><a href="javascript:document.getElementById('logoutForm').submit()">Log off</a></li>
        </ul>
    End Using
Else
    @<ul class="nav navbar-nav pull-right" style="margin-top:10px">
    <li>@Html.ActionLink("ورود", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "loginLink"})</li> 
    <li style="margin-top:15px;color:#9d9d9d">/</li>
    <li>@Html.ActionLink("ثبت نام", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink"})</li>
</ul>
End If

