using LINQ_ProductReviewManagement;

namespace LINQ_ProductReviewManagement
{

    public class Management
    {
        public static void TopThreeByRating(List<ProductReview> productReview)
        {

            var Record = (from productreview in productReview orderby productreview.Rating descending select productreview);

            foreach (var element in Record)
            {
                Console.WriteLine("ProductID :{0}, UserID :{1}, Rating :{2}, Review :{3}, isLike :{4}", element.ProductId, element.UserID, element.Rating, element.Review, element.isLike);
            }
        }

        public static void RetrieveAllRecords(List<ProductReview> productReview)
        {

            var Record = from productreview in productReview
                         where (productreview.ProductId == 1 || productreview.ProductId == 4 || productreview.ProductId == 9)
                         && productreview.Rating > 3
                         select productreview;

            foreach (var element in Record)
            {
                Console.WriteLine("ProductID :{0}, UserID :{1}, Rating :{2}, Review :{3}, isLike :{4}", element.ProductID, element.UserID, element.Rating, element.Review, element.isLike);
            }
        }

        public static void retriveCountOfReviewForEachProductID(List<ProductReview> productReview)
        {

            var Record = productReview.GroupBy(x => x.ProductId).Select(x => new { productid = x.Key, count = x.Count() });

            foreach (var element in Record)
            {
                Console.WriteLine("ProductId :{0}, Count :{1}", element.productid, element.count);
            }
        }

        public static void retriveOnlyProductIDAndReview(List<ProductReview> productreview)
        {
            var Record = from productReview in productreview select productreview;

            foreach (var element in Record)
            {
                Console.WriteLine("ProductId :{0},  Review :{1}", element.ProductId, element.Review);
            }
        }
    }
}
