using System;

namespace Lua {
  public abstract class Closure : Reference {
    public Reference Env;

    public Closure() { }

    public override bool Equals(Reference o) {
      return (o == this);
    }
    public override bool LessThan(Reference o) {
      throw new Exception("not supported");
    }
    public override bool LessThanOrEquals(Reference o) {
      throw new Exception("not supported");
    }

    public override object Length() {
      throw new Exception("not supported");
    }

    public override object this[object key] { 
      get {
      throw new Exception("not supported");
      }
      set {
      throw new Exception("not supported");
      }
    }
    
    public override Table Metatable { 
      get {
      throw new Exception("not supported");
      }
      set {
      throw new Exception("not supported");
      }
    }

  }
}