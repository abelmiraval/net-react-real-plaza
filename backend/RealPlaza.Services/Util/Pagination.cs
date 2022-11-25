namespace RealPlaza.Services.Utils
{
    public class Pagination
    {
        public static int GetTotalPages(int total, int rows)
        {
            var totalPages = total / rows;
            if (total % rows > 0)
                totalPages++;

            return totalPages;
        }
    }
}