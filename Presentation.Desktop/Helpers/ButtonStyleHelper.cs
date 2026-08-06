using System.Drawing.Drawing2D;

namespace SGA.Presentation.Desktop.Helpers
{
    public static class ButtonStyleHelper
    {

        public static void AplicarEstilo(
            Button boton,
            Color colorFondo)
        {

            boton.BackColor = colorFondo;

            boton.ForeColor = Color.White;

            boton.FlatStyle =
                FlatStyle.Flat;


            boton.FlatAppearance.BorderSize =
                0;


            boton.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);


            boton.Cursor =
                Cursors.Hand;


            boton.Height = 42;


            boton.Region =
                CrearRegionRedondeada(
                    boton.Width,
                    boton.Height,
                    12);



            boton.MouseEnter += (s, e) =>
            {
                boton.BackColor =
                    ControlPaint.Dark(colorFondo);
            };


            boton.MouseLeave += (s, e) =>
            {
                boton.BackColor =
                    colorFondo;
            };
        }




        private static Region CrearRegionRedondeada(
            int ancho,
            int alto,
            int radio)
        {

            GraphicsPath path =
                new GraphicsPath();


            path.AddArc(
                0,
                0,
                radio,
                radio,
                180,
                90);


            path.AddArc(
                ancho - radio,
                0,
                radio,
                radio,
                270,
                90);


            path.AddArc(
                ancho - radio,
                alto - radio,
                radio,
                radio,
                0,
                90);


            path.AddArc(
                0,
                alto - radio,
                radio,
                radio,
                90,
                90);


            path.CloseFigure();


            return new Region(path);
        }
    }
}
