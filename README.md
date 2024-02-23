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

Podgląd aplikacja można zauważyć na zdjęciach główna.PNG oraz podstrona.PNG

![główna](https://github.com/Annoonn/App_Booking/assets/92316175/f9970781-bae5-4f3f-b9b3-2436a7166642)
![podstrona](https://github.com/Annoonn/App_Booking/assets/92316175/daf0ecda-a3b9-4215-bf44-d72d8ff76ccf)
