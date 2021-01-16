using System;
using System.Collections.Generic;
using System.Text;

namespace Athletics
{
    public interface INewsRepository
    {
        News[] GetById(int id);
        News[] GetAllByTitle(string titlePart);
        News[] GetAllByDescription(string descriptionPart);
        News[] GetAllByBodyText(string bodytextPart);
        News[] GetAllByTag(string tagPart);
    }
}
