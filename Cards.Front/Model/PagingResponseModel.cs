namespace Cards.Front.Model
{
    /// <summary>
    ///     Обобщённый класс для представления постраничного вывода
    /// </summary>
    /// <typeparam name="TItem">Тип элемента в коллекции</typeparam>
    public class PagingResponseModel<TItem>
    {
        /// <summary>
        ///     Всего элементов в коллекции
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        ///     Содержимое запрошенной страницы
        /// </summary>
        public TItem[] Items { get; set; }
    }
}
