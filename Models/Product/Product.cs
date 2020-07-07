using System;
namespace seg.core.Models.Product
{
    public abstract class Product : _BaseModel
    {
        private string name = null;
        public string Name
        {
            set { SetProperty(ref name, value); }
            get { return name; }
        }

        private string category = null;
        public string Category
        {
            set { SetProperty(ref category, value); }
            get { return category; }
        }

        public Product()
        {

        }

        public Product(string name)
        {
            this.Name = name;
        }


    }
}
