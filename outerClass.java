import java.io.*;

public class outerClass{
   static String outside = "This is outside the class";

    class innerClass{
        public void print(){
            System.out.println("This is an inner class");
            System.out.println(outside);
        }
    }//innerClass

   static class innerClass2{
        public void print(){
            System.out.println("This is an inner static class");
            System.out.println(outside);
        }
    }//innerClass2

    public static void main(String[] args) {
        outerClass outer = new outerClass();
        outerClass.innerClass inner = outer.new innerClass();
        inner.print();

        outerClass.innerClass2 inner2 = new outerClass.innerClass2();
        inner2.print();
    }
}