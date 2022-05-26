class Test{
    public int z = 10;
}

class Main{
Test t = new Test();
Test t2 = t;

t.z = 1000;
}