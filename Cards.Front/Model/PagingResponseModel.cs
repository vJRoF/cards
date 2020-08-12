using System;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public int TotalCount { get; set; }

        /// <summary>
        ///     Содержимое запрошенной страницы
        /// </summary>
        [Required]
        public TItem[] Items { get; set; } = Array.Empty<TItem>();
    }
}
