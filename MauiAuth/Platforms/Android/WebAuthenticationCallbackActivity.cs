using Android.App;
using Android.Content.PM;
using c = Android.Content;

namespace MauiAuth.Platforms.Android;

[Activity(NoHistory = true, LaunchMode = LaunchMode.SingleTop, Exported = true)]
[IntentFilter(new[] { c.Intent.ActionView },
    Categories = new[] {
            c.Intent.CategoryDefault,
            c.Intent.CategoryBrowsable
        },
    DataScheme = CALLBACK_SCHEME)]
public class WebAuthenticationCallbackActivity : Microsoft.Maui.Authentication.WebAuthenticatorCallbackActivity
{
    const string CALLBACK_SCHEME = "myapp";
}
