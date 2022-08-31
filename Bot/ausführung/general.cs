using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;


namespace Bot.ausführung
{
    public class general : ModuleBase
    {
        [Command("ping")]
        public async Task Ping()
        {
            await Context.Channel.SendMessageAsync("Pong!");
        }
      
        [Command("witz")]

        public async Task PWitz()
        {

            string w1 = "Sagt die Ehefrau am Telefon: Sorry Schatz, ich kann einfach nicht mehr. Wir sollten uns trennen--------Sagt der Mann: ,,Ja gut, aber du legst zuerst auf!“";
            string w2 = "Warum ist der Donat zum Zahnarzt gegangen?-------Um eine neue Füllung zu bekommen!";
            string w3 = "das L in frauen steht für Lustig";
            string w4 = "Warum musste der Bäcker ins Gefängnis? ---------Er hat zu viele Eier geschlagen.";
            string w5 = "Ein Beamter zum anderen: Was haben die Leute nur, wir tun doch nichts.";
            string w6 = "Im Rezept stand „Ofen auf 90 Grad stellen“.--------- Und wie kriege ich jetzt den Ofen auf?";
            string w7 = "Was hat vier Beine und kann fliegen?-------Zwei Vögel.";
            string w8 = "Was sind die letzten Worte eines Fallschirmspringers-------“Immer diese scheiß Motten“";
            string w9 = "Wollte heute mal ganz sexy kucken. Wurde dann mit Verdacht auf Schlaganfall ins Krankenhaus gebracht.";
            string w10 = "Warum hat der Kapitän das U-Boot versenkt?----------Es war Tag der offenen Tür.";
            string w11 = "Wie nennt man auf Chinesisch Oberschenkelbeinbruch?---------Knicki - Knacki Nah - Bei - Sacki. ";
            string w12 = "Warum trinken Veganer kein Leitungswasser?---------Weil es aus dem Hahn kommt!";
            string w13 = "Wie war eigentlich die Stimmung in der DDR?-----Sie hielt sich so ziemlich in Grenzen.";
            string w14 = "Welchen Tee sollte man besser nicht trinken?--------- TNT";
            string w15 = "Oma, wieso eigentlich stöberst du die ganze Zeit in den Todesanzeigen?--------Ich wollte wissen, wer wieder Single geworden ist.";
            string w16 = "2 Architekten in Pisa.Fragt der eine Willst du den Turm wirklich so hoch bauen?---------Sagt der andere Was kann da schon schief gehen";
            string w17 = "Patient: Ich bin so nervös. Das ist meine erste Operation.-------Doktor: Keine Sorge, meine auch.";
            string w18 = "Archäologe bei einer Ausgrabung: Das Skelet ist eindeutig weiblich.Die Kiefergelenke sind stark abgenutzt. ";
            string w19 = "Treffen sich zwei Wellen in der Nordsee.---------------Sagt die eine: Ich glaub, ich muss gleich brechen";
            string w20 = "Papi, was ist ein Transvestit? ------- Da musst du die Mama fragen, der weiß das!";
            string w21 = "Was geht einer Fliege durch den Kopf, wenn sie mit 160km/h gegen die Windschutzscheibe fliegt?------------Der Hintern";
            string w22 = "Wie waren die letzten Worte des Sportlehrers?------------Alle Speere zu mir.";
            string w23 = "Wie nennt man das Weiße in Vogelscheiße? Auch Vogelscheiße!";
            string w24 = "Der weltweit kürzeste Witz:-------------Holzeisenbahn";
            string w25 = "Papi, da ist so ein Mann an der Tür. Er sagt, er sammelt für das Altersheim.---------------Oh, dass ist super.Gibt ihm Opa mit.  ";
            string w26 = "Welchen Walen geht man besser aus dem Weg?----------------Den Schwertwalen";
            string w27 = "Wie kastriert man einen Kühlschrank ?---------------Kühlschranktür auf, Eier raus, Tür zu!";
            string w28 = "Was ist braun, klebrig und läuft durch die Wüste?---------Ein KarameL";
            string w29 = "Welcher Fisch ist am nervigsten?-------------Der Stör";
            string w30 = "Zwei Mathematiker sitzen vor einer schönen Frau und reden. Was machen sie?--------------Kurvendiskussion";
            string w31 = "Wer kaut und hat immer Verspätung?-------------Die Essbahn";
            string w32 = "Wo bräunt sich die fromme Frau?-----------Im Nonnenstudio";
            string w33 = "Was passiert wenn man Cola und Bier gleichzeitig trinkt?-------------Man colabiert";
            string w34 = "Wo sind Meerschweinchen unerwünscht?------------In Hamsterdam!";
            string w35 = "Was findet man beim Kannibalen in der Dusche?-------------Head and Shoulders";



            Random random1 = new Random();
            random1.Next(1, 36);
            int x = random1.Next(1, 36);


            if (x == 1)
            {
                await Context.Channel.SendMessageAsync(w1);
            }

            if (x == 2)
            {
                await Context.Channel.SendMessageAsync(w2);
            }

            if (x == 3)
            {
                await Context.Channel.SendMessageAsync(w3);
            }

            if (x == 4)
            {
                await Context.Channel.SendMessageAsync(w4);
            }

            if (x == 5)
            {
                await Context.Channel.SendMessageAsync(w5);
            }

            if (x == 6)
            {
                await Context.Channel.SendMessageAsync(w6);
            }

            if (x == 7)
            {
                await Context.Channel.SendMessageAsync(w7);
            }

            if (x == 8)
            {
                await Context.Channel.SendMessageAsync(w8);
            }

            if (x == 9)
            {
                await Context.Channel.SendMessageAsync(w9);
            }

            if (x == 10)
            {
                await Context.Channel.SendMessageAsync(w10);
            }

            if (x == 11)
            {
                await Context.Channel.SendMessageAsync(w11);
            }

            if (x == 12)
            {
                await Context.Channel.SendMessageAsync(w12);
            }

            if (x == 13)
            {
                await Context.Channel.SendMessageAsync(w13);
            }

            if (x == 14)
            {
                await Context.Channel.SendMessageAsync(w14);
            }

            if (x == 15)
            {
                await Context.Channel.SendMessageAsync(w15);
            }

            if (x == 16)
            {
                await Context.Channel.SendMessageAsync(w16);
            }

            if (x == 17)
            {
                await Context.Channel.SendMessageAsync(w17);
            }

            if (x == 18)
            {
                await Context.Channel.SendMessageAsync(w18);
            }

            if (x == 19)
            {
                await Context.Channel.SendMessageAsync(w19);
            }

            if (x == 20)
            {
                await Context.Channel.SendMessageAsync(w20);
            }

            if (x == 21)
            {
                await Context.Channel.SendMessageAsync(w21);
            }

            if (x == 22)
            {
                await Context.Channel.SendMessageAsync(w22);
            }

            if (x == 23)
            {
                await Context.Channel.SendMessageAsync(w23);
            }

            if (x == 24)
            {
                await Context.Channel.SendMessageAsync(w24);
            }

            if (x == 25)
            {
                await Context.Channel.SendMessageAsync(w25);
            }

            if (x == 26)
            {
                await Context.Channel.SendMessageAsync(w26);
            }

            if (x == 27)
            {
                await Context.Channel.SendMessageAsync(w27);
            }

            if (x == 28)
            {
                await Context.Channel.SendMessageAsync(w28);
            }

            if (x == 29)
            {
                await Context.Channel.SendMessageAsync(w29);
            }

            if (x == 30)
            {
                await Context.Channel.SendMessageAsync(w30);
            }

            if (x == 31)
            {
                await Context.Channel.SendMessageAsync(w31);
            }

            if (x == 32)
            {
                await Context.Channel.SendMessageAsync(w32);
            }

            if (x == 33)
            {
                await Context.Channel.SendMessageAsync(w33);
            }

            if (x == 34)
            {
                await Context.Channel.SendMessageAsync(w34);
            }

            if (x == 35)
            {
                await Context.Channel.SendMessageAsync(w35);
            }


        }



      




    }
}
