
/*
namespace LINQ_ProductReviewManagement

    public class Management
    {
        public static void TopThreeByRating(List<ProductReview> productReview)
        {

            var Record = (from productreview in productReview orderby productreview.Rating descending select productreview);

            foreach (var element in Record)
            {
                Console.WriteLine("ProductID :{0}, UserID :{1}, Rating :{2}, Review :{3}, isLike :{4}", element.ProductId, element.UserId, element.Rating, element.Review, element.isLike);
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
                Console.WriteLine("ProductId :{0}, UserID :{1}, Rating :{2}, Review :{3}, isLike :{4}", element.ProductId, element.UserId, element.Rating, element.Review, element.isLike);
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

        public static void retriveOnlyProductIDAndReview(List<ProductReview> productReview)
        {
            var Records = from productreview in productReview select productreview;

            foreach (var element in Records)
            {
                Console.WriteLine("ProductId :{0},  Review :{1}", element.ProductId, element.Review);
            }
        }

        public static void skipTopFiveRecordAndDisplayOther(List<ProductReview> productReview)
        {
            var Records = (from productreview in productReview select productreview).Skip(5);

            foreach (var element in Records)
            {
                Console.WriteLine("ProductId :{0},  Review :{1}", element.ProductId, element.Review);
            }
        }

        public static void retriveOnlyProductIDAndReviewAllRecordsUsingSelect(List<ProductReview> ele)
        {
            var Records = ele.AsEnumerable().Select(x => new { ProductId = x.ProductId, review = x.Review });

            foreach (var element in Records)
            {
                Console.WriteLine("ProductId :{0},  Review :{1}", element.ProductId, element.review);
            }
        }
    }
}
*/

