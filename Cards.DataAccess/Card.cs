using System;
using System.Collections.Generic;
using System.Text;

namespace Cards.DataAccess
{
    class Card
    {
        /// <summary>
        ///     Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Имя колоды
        /// </summary>
        public string DeckName { get; set; }

        /// <summary>
        ///     Uri картинки
        /// </summary>
        public Uri PictureUri { get; set; }
    }
}
