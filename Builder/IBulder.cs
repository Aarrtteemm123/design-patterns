namespace Builder
{
    public interface IBulder
    {
        void reset();
        void setTomato(int number);
        void setMushrooms(int number);
        void setCheese(int number);
        void setOnion(int number);
        void setBacon(int number);
        void setParsley(int number);
        void setMeat(int number);
        Pizza getResult();
    }
}