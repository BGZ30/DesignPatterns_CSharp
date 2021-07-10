namespace NaiveBuilderExample
{
    public class ConcreteBuilder : IBuilder{
        private Product product = new Product();

        public ConcreteBuilder(){
            this.reset();
        }

        public void reset(){
            this.product = new Product();
        }

        public void buildPartA(){
            this.product.add("PartA");
        }

        public void buildPartB(){
            this.product.add("PartB");
        }

        public void buildPartC(){
            this.product.add("PartC");
        }

        public Product getProduct(){
            Product result = this.product;
            this.reset();

            return result;
        }
    }
}