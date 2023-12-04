using ConsoleApp1;

Handler bankManager = new BankManager();
Handler regionalManager = new RegionalManager();
Handler headOffice = new HeadOffice();

bankManager.SetSuccessor(regionalManager);
regionalManager.SetSuccessor(headOffice);


bankManager.HandleRequest(8000);
bankManager.HandleRequest(25000);
bankManager.HandleRequest(70000);