using System;
using System.Data;

namespace Warden.Component.Common.Carousel {
    public partial class CarouselUsc : BaseUsc {

        public class Image {
            public String Url { get; set; }
            public String Text { get; set; }
            public String Title { get; set; }
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }

        public Image[] Itens { get; set; }

        public void LoadDataSource(Image [] Images) {

            try {
                if (Images.Length > 0) {
                    Itens = Images;
                } else {
                    throw new Exception("As imagens não foram informadas !");
                }
            } catch (Exception Err) {
                throw new Exception(Err.Message);
            }
        }
    }
}