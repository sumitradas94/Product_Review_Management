using LINQ_ProductReviewManagement;

namespace LINQ_ProductReviewManagement
{
   
    public class Management
    {
        public static void RetrieveAllRecords(List<ProductReview> productReview)
        {

            var Record = from productreview in productReview
                         where (productreview.ProductId == 1 || productreview.ProductId == 4 || productreview.ProductId == 9)
                         && productreview.Rating > 3
                         select productreview;

            foreach (var element in Record)
            {
                Console.WriteLine("ProductID :{0}, UserID :{1}, Rating :{2}, Review :{3}, isLike :{4}", element.ProductId, element.UserId, element.Rating, element.Review, element.isLike);
            }
        }
    }
}