Owner o = new Owner("Owner", 1000000);
Server s = new Server("Server");
Cook c = new Cook("Cook");
Menu set = new Menu("정식", 5000);
Menu special = new Menu("특식", 7000);
Menu coke = new Menu("콜라", 2000);
Menu soda = new Menu("사이다", 2000);


Customer c1 = new Customer("c1");
c1.orderFood(set, 1, s);
c1.orderFood(soda, 1, s);
s.passOrder(c);
s.serveFood(c1);
c1.giveMoney(s);


Customer c23 = new Customer("c23");
c23.orderFood(special, 2, s);
c23.orderFood(coke, 2, s);
s.passOrder(c);
s.serveFood(c23);
c23.giveMoney(s);


s.giveMoney(o);
o.paySalary(50000, 2);
o.leftMoney();