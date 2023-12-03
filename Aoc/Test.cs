namespace Aoc;
public class Test
{
  protected void log(str txt) => 
    System.Diagnostics.Debug.WriteLine(txt);
  protected void chk(bln cond) => 
    Assert.IsTrue(cond);
}