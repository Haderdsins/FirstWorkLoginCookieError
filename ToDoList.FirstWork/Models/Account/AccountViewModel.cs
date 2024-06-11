using System.ComponentModel.DataAnnotations;

namespace FirstWork.Models.Account;

/// <summary>
///     Модель страницы аккаунт
/// </summary>
public class AccountViewModel
{
    public LoginViewModel LoginViewModel { get; set; }

    public RegisterViewModel RegisterViewModel { get; set; }
}

public class LoginViewModel //модель для авторизации
{
    [Required(ErrorMessage = "Данное поле обязательное")]
    public string Login { get; set; }

    [Required(ErrorMessage = "Данное поле обязательное")]
    public string Password { get; set; }
}

public class RegisterViewModel //модель для регистрации
{
    [Required(ErrorMessage = "Данное поле обязательное")]
    public string Login { get; set; }

    [Required(ErrorMessage = "Данное поле обязательное")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Данное поле обязательное")]
    [Compare("Password", ErrorMessage = "Пароли не совпадают")]
    public string RepeatPassword { get; set; }
}