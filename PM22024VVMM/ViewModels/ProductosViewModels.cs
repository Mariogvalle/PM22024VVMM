
using System.Windows.Input;

namespace PM22024VVMM.ViewModels
{
    public class ProductosViewModels: BaseViewModels
    {
        private string _descripcion;
        private double _precio;
        private string _foto;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; OnPropertyChanged(); }
        }

        public Double Precio
        {
            get { return _precio; }
            set { _precio = value; OnPropertyChanged(); }
        }

        public string Foto
        {
            get { return _foto; }
            set { _foto = value; OnPropertyChanged(); }
        }

        public ICommand CreateCommand { get; set; }
        public ICommand ReadCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand CleanCommand { get; set; }

        void Clear()
        {
            Descripcion = String.Empty;
            Foto = String.Empty;
            Precio = 0.0;
        }

        async Task Create()
        {
            try
            {
                Models.Productos prd = new Models.Productos
                {
                    Descripcion = Descripcion,
                    Precio = Precio,
                    Foto = Foto
                };

                //consumo del restapi
                //crud SQLite
                await Task.Delay(1000);
            }
            catch
            {

            }
        }
        public ProductosViewModels()
        {
            CleanCommand = new Command(Clear);
            CreateCommand = new Command(async () => await Create());
        }

    }
}
