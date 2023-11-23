# App_Booking
Prototyp aplikacji podobnej do Bookingowej

W tym projekcie skupiłem się na prymitywnej wersjii aplikacji do Bookowania wyjazdów, można 
tutaj znaleźć takie elementy jak karuzele z obrazkami miejsc które można odwiedzić, 4 ikonki
z przygodą, którą możemy dobrać pod swoje preferencje np. kayakarstwo. Również znajduję się 
tutaj DetailPage, który wyświetla szczegóły danej lokalizacji, jej cenę, czas oraz recenzje.

Ciekawe rzeczy które znalazłem podczas tworzenia aplikacjii:
pancake.PNG
Znalazłem że zamiast <Frame> tradycyjnego można zainstalować pakiet Nuget taki jak 
Xamarin.Forms.PancakeView, żeby go użyć musimy również dodać na górze namespace 
xmlns:pancake="clr-namespace:Xamarin.Forms.PancakeView;assembly=Xamarin.Forms.PancakeView", 
ale to powinno podświetlić błąd i w szybkim rozwiązaniu problemu powinno automatycznie dodać go.
