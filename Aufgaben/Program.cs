/*
 * Frage Nutzer nach Eingabe von name
 * Frage Nutzer nach Eingabe von password
 * 
 * Falls name und password korrekt:
 *     Wahr:
 *         Sende onetimepassword
 *         Frage Nutzer nach Eingabe von onetimepassword
 *         Falls onetimepassword korrekt: 
 *             Wahr: Sende Nachricht "Willkommen"
 *             Falsch: Erneute Eingabeaufforderung
 *     Falsch:
 *         Erneute Eingabeaufforderung
 */

/*
 * Initialisiere prescriptionColor mit dem Wert leer
 * Frage Nutzer nach insuranceType
 * Frage Nutzer nach medType
 *
 * 
 * Prüfe insuranceType gleich gesetzlich:
 *     Wahr:
 *         Prüfe medType gleich "verschreibungspflichtig":
 *             Wahr:
 *                 Setze prescriptionColor gleich rosa
 *             Falsch:
 *                 Setze prescriptionColor gleich grün
 *     Falsch:
 *         Prüfe medType gleich "verschreibungspflichtig":
 *             Wahr:
 *                 Setze prescriptonColor gleich gelb
 *             Falsch:
 *                 Setze prescriptionColor gleich blau
 * Gebe prescriptionColor zurück
 */