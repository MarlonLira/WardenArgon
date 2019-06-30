using System;
using System.Web.UI;

namespace Warden.Component {
    public partial class BaseUsc : UserControl {
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }
        public String Icon { get; set; }
        public String Url { get; set; }
        public Int32 Type { get; set; }

        public String NavigateForUrl() {
            String ResultUrl = "";

            try {
                ResultUrl = Helper.Help.FormatUrl(Url);

            } catch (Exception Err) {
                throw new Exception(Err.Message);
            }

            return ResultUrl;
        }

        public String LoadType() {
            String NewType = "";

            if (Type <= 0) {
                
            }

            switch (Type) {
                case 1: {
                    NewType = "primary";
                    break;
                }

                case 2: {
                    NewType = "success";
                     break;
                }

                case 3: {
                    NewType = "warning";
                    break;
                }

                default: {
                    NewType = "primary";
                    break;
                }
            }


            return NewType;
        }
        public String LoadIcon() {
            String CreateIcon = "";
            if (String.IsNullOrEmpty(Icon)) { Icon = ""; }
            switch (Icon.ToUpper()) {
                case "EMAIL": {
                        CreateIcon = "ni ni-email-83";
                        break;
                    }
                case "PASSWORD": {
                        CreateIcon = "ni ni-lock-circle-open";
                        break;
                    }
                case "USER": {
                        CreateIcon = "ni ni-single-02";
                        break;
                    }
                case "RUN": {
                        CreateIcon = "ni ni-user-run";
                        break;
                    }
                case "WAVE": {
                        CreateIcon = "ni ni-sound-wave";
                        break;
                    }
                case "GEAR": {
                        CreateIcon = "ni ni-settings-gear-65";
                        break;
                    }
                case "SETTINGS": {
                        CreateIcon = "ni ni-settings";
                        break;
                    }
                case "SATISFIED": {
                        CreateIcon = "ni ni-satisfied";
                        break;
                    }
                case "COLLECTION": {
                        CreateIcon = "ni ni-collection";
                        break;
                    }
                case "BADGE": {
                        CreateIcon = "ni ni-badge";
                        break;
                    }
                case "ATOM": {
                        CreateIcon = "ni ni-atom";
                        break;
                    }
                case "WORLD": {
                        CreateIcon = "ni ni-world";
                        break;
                    }
                case "SUPPORT": {
                        CreateIcon = "ni ni-support-16";
                        break;
                    }
                case "PHONE": {
                        CreateIcon = "ni ni-headphones";
                        break;
                    }
                case "DATE": {
                        CreateIcon = "ni ni-calendar-grid-58";
                        break;
                    }
                case "CITY": {
                        CreateIcon = "ni ni-istanbul";
                        break;
                    }
                case "CEP": {
                        CreateIcon = "ni ni-square-pin";
                        break;
                    }
                case "GENDER": {
                        CreateIcon = "fa fa-venus-mars";
                        break;
                    }
                case "COMPANY": {
                        CreateIcon = "fa fa-building";
                        break;
                    }
                case "ADRESS": {
                        CreateIcon = "fa fa-map-marker";
                        break;
                    }
                case "UI": {
                        CreateIcon = "ni ni-ui-04";
                        break;
                    }
                case "PALETTE": {
                        CreateIcon = "ni ni-palette";
                        break;
                    }
                case "SPACESHIP": {
                        CreateIcon = "ni ni-spaceship";
                        break;
                    }
                default: {
                        CreateIcon = "";
                        break;
                    }
            }

            return CreateIcon;
        }
    }
}