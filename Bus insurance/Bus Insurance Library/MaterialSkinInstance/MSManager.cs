using MaterialSkin;

namespace Bus_Insurance_Library.MaterialSkinInstance
{
    public static class MSManager
    {
        public static bool State { get; set; }

        public static void SkinManager(MaterialSkin.Controls.MaterialForm form)
        {
            if (State)
            {
                MaterialSkinManager materiaSkinManager = MaterialSkinManager.Instance;
                materiaSkinManager.AddFormToManage(form);
                materiaSkinManager.Theme = MaterialSkinManager.Themes.DARK;

                materiaSkinManager.ColorScheme = new ColorScheme(

                    Primary.Red800, Primary.Red500,
                    Primary.Red700, Accent.Red700,

                    TextShade.BLACK

                    ); 
            }
            else
            {
                MaterialSkinManager materiaSkinManager = MaterialSkinManager.Instance;
                materiaSkinManager.AddFormToManage(form);
                materiaSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

                materiaSkinManager.ColorScheme = new ColorScheme(

                    Primary.Blue800, Primary.Blue600,
                    Primary.Blue700, Accent.Blue700,

                    TextShade.WHITE

                    );

            }
        }

    }
}
