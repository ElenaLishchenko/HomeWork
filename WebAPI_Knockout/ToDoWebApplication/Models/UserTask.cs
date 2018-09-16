using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoClassLibrary
{
	/// <summary>
	/// Класс UserTask - задача, базовая сущность приложения.
	/// </summary>
	public class UserTask:IEquatable<UserTask>
    {
	    public int Id { get; set; }
	    public string Title { get; set; }
		public DateTime CreatedWhen { get; set; }

		public bool Equals(UserTask other)
	    {
		    if (ReferenceEquals(null, other)) return false;
		    if (ReferenceEquals(this, other)) return true;
		    return Id == other.Id && string.Equals(Title, other.Title) && CreatedWhen.Equals(other.CreatedWhen);
	    }

	    public override bool Equals(object obj)
	    {
		    if (ReferenceEquals(null, obj)) return false;
		    if (ReferenceEquals(this, obj)) return true;
		    if (obj.GetType() != this.GetType()) return false;
		    return Equals((UserTask) obj);
	    }

	    public override int GetHashCode()
	    {
		    unchecked
		    {
			    var hashCode = Id;
			    hashCode = (hashCode * 397) ^ (Title != null ? Title.GetHashCode() : 0);
			    hashCode = (hashCode * 397) ^ CreatedWhen.GetHashCode();
			    return hashCode;
		    }
	    }
    }
}
