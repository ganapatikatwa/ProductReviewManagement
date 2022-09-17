namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Product review management");
            List<ProductReview> productreviewlist = new List<ProductReview>()
            {
                new ProductReview(){ProductID = 1, UserID = 1,Rating=5,Review="good",islike=true},
                new ProductReview(){ProductID = 2, UserID = 1,Rating=2,Review="bad",islike=true},
                new ProductReview(){ProductID = 3, UserID = 1,Rating=5,Review="good",islike=true},
                new ProductReview(){ProductID = 4, UserID = 1,Rating=4,Review="bad",islike=true},
                new ProductReview(){ProductID = 5, UserID = 1,Rating=3,Review="good",islike=true}
            };

            foreach (var products in productreviewlist)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine(products.ProductID + " | " + products.UserID + " | " + products.Rating + " | " + products.Review + " | " + products.islike);

            }

        }
       
        

    }
        
}
