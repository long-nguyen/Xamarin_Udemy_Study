using System;
using Xamarin.Forms.Xaml;

namespace TestXamarin.MarkupResource
{
    [Xamarin.Forms.ContentProperty("ResourceId")]
    public class EmbeddedImage: IMarkupExtension
    {
        public String ResourceId { get; set; }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            if (String.IsNullOrWhiteSpace(ResourceId)) {
                return null;
            }

            return Xamarin.Forms.ImageSource.FromResource("TestXamarin.Images.tesimg.jpg");
        }
    }
}
