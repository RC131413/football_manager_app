# football_manager_app# Football Clubs Manager

## Opis aplikacji

Football Clubs Manager to desktopowa aplikacja (Windows Forms) do zarządzania danymi piłkarskimi: klubami, zawodnikami, rozgrywkami, meczami i zdarzeniami meczowymi. Wszystkie dane przechowywane są lokalnie w bazie SQLite.

---

## Funkcjonalności

- Przeglądanie, dodawanie, edycja i usuwanie klubów, zawodników, rozgrywek, meczów oraz zdarzeń meczowych
- Edycja danych bezpośrednio w tabelach lub przez dedykowane formularze
- Automatyczne wypełnianie bazy przykładowymi danymi przy pierwszym uruchomieniu (seedery)
- Intuicyjny interfejs oparty na zakładkach/widokach

---

## Widoki

- **Kluby:** lista klubów z możliwością dodawania, edycji i usuwania
- **Zawodnicy:** lista zawodników z opcją filtrowania po klubie, pełna edycja i usuwanie
- **Rozgrywki:** zarządzanie sezonami i typami rozgrywek
- **Mecze:** lista meczów z wynikami, edycja przez formularz, podgląd zdarzeń meczu
- **Zdarzenia meczowe:** lista zdarzeń (gole, kartki, itp.) z możliwością edycji i usuwania

---

## Struktura bazy danych

**Clubs**
- Id: klucz główny
- Name: nazwa klubu
- City: miasto
- Stadium: stadion
- FoundedDate: data założenia

**Players**
- Id: klucz główny
- FirstName: imię
- LastName: nazwisko
- Position: pozycja
- Number: numer
- ClubId: powiązanie z klubem

**Competitions**
- Id: klucz główny
- Name: nazwa rozgrywek
- Season: sezon

**Matches**
- Id: klucz główny
- Date: data meczu
- HomeClubId: klub gospodarzy
- AwayClubId: klub gości
- HomeScore: gole gospodarzy
- AwayScore: gole gości
- CompetitionId: powiązanie z rozgrywkami

**MatchEvents**
- Id: klucz główny
- MatchId: powiązanie z meczem
- Minute: minuta zdarzenia
- PlayerId: powiązanie z zawodnikiem
- EventType: typ zdarzenia (np. gol, kartka)

---

## Użytkowanie

Po uruchomieniu aplikacji możesz zarządzać wszystkimi danymi piłkarskimi z poziomu czytelnych tabel. Każdy widok pozwala na szybkie dodawanie, edycję lub usuwanie rekordów. Wszystkie zmiany są zapisywane automatycznie w bazie danych, a przykładowe dane pojawią się automatycznie przy pierwszym uruchomieniu.

## Autor

Autor: Radosław Cebula