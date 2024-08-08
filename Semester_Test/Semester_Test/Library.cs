using System.Collections.Generic;

namespace Semester_Test
{
    class Library
    {
        List <LibraryResource> resources = new List<LibraryResource>();
        public Library(string name)
        {

        }
        public bool HasResource(string name)
        {
            foreach (LibraryResource resource in resources)
            {
                if (resource.Name == name)
                {
                    if (!resource.OnLoan)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void AddResource(LibraryResource resource)
        {
            resources.Add(resource);
        }

    }
}

//Tran Quoc Dung 103803891