﻿namespace PizzaStore
{
    public interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Box();
    }
}