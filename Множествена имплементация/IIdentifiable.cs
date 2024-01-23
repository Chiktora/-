using System;
using System.Collections.Generic;
using System.Text;

namespace Множествена_имплементация
{
    internal interface IIdentifiable
    {
        string Id { get; }
    }

    public interface IBirthable
    {
        string Birthdate { get; }
    }
}
