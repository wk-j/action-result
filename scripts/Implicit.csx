
interface A { }
class B : A { }

public class ActionResult<T> {
    public ActionResult(T t) => Value = t;
    public T Value { set; get; }
    public static implicit operator ActionResult<T>(T t) {
        return new ActionResult<T>(t);
    }
}

A CreateA() => new B();

ActionResult<string> a1 = "Hello";
ActionResult<int> a2 = 100;
ActionResult<IEnumerable<string>> a3 = new string[] { };
ActionResult<IEnumerable<string>> a4 = Enumerable.Empty<string>();
ActionResult<A> a5 = new B();
ActionResult<A> a6 = CreateA();

