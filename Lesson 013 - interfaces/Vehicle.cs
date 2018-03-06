using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_013___interfaces
{
    /*
     * The interface defined the methods that must be overridden within a derived class.
     * All methods must be overridden for a derived class to compile.
     * Interfaces allow for a multiple classes to be implemented to a specific contract,
     * ensuring that all methods will be implemented.
     * Because an interface does not implement any methods, it is not possible to create
     * an interface as an object.
     * i.e. It's not possible to do this:
     *     Vehicle v = new Vehicle(); // This is an error!
     */
    public interface Vehicle
    {
        string GetModel();
        string GetManufacturer();
    }
}
