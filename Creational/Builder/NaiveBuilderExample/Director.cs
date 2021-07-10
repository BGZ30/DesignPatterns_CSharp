namespace NaiveBuilderExample
{
    public class Director{
        private IBuilder _builder;

        public IBuilder builder{ 
            set { _builder = value; }
        }

        public void buildRowProduct(){
            this._builder.buildPartA();
        }

        public void buildFullProduct(){
            this._builder.buildPartA();
            this._builder.buildPartB();
            this._builder.buildPartC();
        }
    }
}