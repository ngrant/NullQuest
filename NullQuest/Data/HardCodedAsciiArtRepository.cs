﻿using BadSnowstorm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullQuest.Data
{
    public class HardCodedAsciiArtRepository : IAsciiArtRepository
    {
        private static readonly string TitleArt = string.Format(@"{0}
 _                 _        _       
( (    /||\     /|( \      ( \      
|  \  ( || )   ( || (      | (      
|   \ | || |   | || |      | |      
| (\ \) || |   | || |      | |      
| | \   || |   | || |      | |      
| )  \  || (___) || (____/\| (____/\
|/    )_)(_______)(_______/(_______/

 _______           _______  _______ _________
(  ___  )|\     /|(  ____ \(  ____ \\__   __/
| (   ) || )   ( || (    \/| (    \/   ) (   
| |   | || |   | || (__    | (_____    | |   
| |   | || |   | ||  __)   (_____  )   | |   
| | /\| || |   | || (            ) |   | |   
| (_\ \ || (___) || (____/\/\____) |   | |   
(____\/_)(_______)(_______/\_______)   )_(   ", ContentArea.YellowForeground);

        private const string DungeonArt = @"
                        ^                       ^                        
                       (_)                     (_)                       
/\    /\    /\    /\   /X\                     /X\   /\    /\    /\    /\
XX____XX____XX____XX___XXX  _________________  XXX___XX____XX____XX____XX
XXXXXXXXXXXXXXXXXXXXXXXXXX |.................| XXXXXXXXXXXXXXXXXXXXXXXXXX
XX    XX    XX    XX   XXX |.               .| XXX   XX    XX    XX    XX
XX    XX    XX    XX   XX/#|:      ___      .| XXX   XX    XX    XX    XX
XX    XX |\_XX __/|X   XX\#|:.....I I I......| XXX   X|\__ XX_/| XX    XX
XX    XX \ _ \/ _ /X   XXX |.    .I_I_I.    .| XXX   X\ _ \/ _ / XX    XX
XX    XX  (I)\/(I)XX   XXX |.       .       .|_XXX   XX(I)\/(I)  XX    XX
XX    XX  \/(oo)\/XX   XXX |...............:(==)XX   XX\/(oo)\/  XX    XX
XX    XX   |V,,V| XX   XXX |.       .       .| XXX   XX |V,,V|   XX    XX
XX____XX  /|A^^A|\XX __XXX |.       .       .| XXX_ _XX/|A^^A|\  XX____XX
XXXXXX/ \/  TTTT  \/\XXXXX |.................| XXXXX/\/  TTTT  \/ \XXXXXX
XX  X/    (  ||  )   \ XX/#|:       .       .| XXX /   (  ||  )    \X  XX
XX_ X_\    \ || /   /__XX\#|:       .       .| XXX__\   \ || /    /_X _XX
XXX/   \   \||||/  /   \XX |.................| XX/   \  \||||/   /   \XXX
XX/   oooo_/||||\_ooo   \X |_________________| X/   ooo_/||||\_oooo   \XX
 /         oooooo        \                     /        oooooo         \ 
/_________________________\                   /_________________________\
|_________________________|                   |_________________________|
 |___I___I___I___I__I___|                       |___I__I___I___I___I___| 
 |_I___I___I___I__I___I_|                       |_I__I___I___I___I___I_| 
";

        private static readonly string PlayerDeadArt = @"
                                                                _    
                                                              _( (~\ 
       _ _                        /                          ( \> > \
   -/~/ / ~\                     :;                \       _  > /(~\/
  || | | /\ ;\                   |l      _____     |;     ( \/    > >
  _\\)\)\)/ ;;;                  `8o __-~     ~\   d|      \      // 
 ///(())(__/~;;\                  X88p;.  -. _\_;.oP        (_._/ /  
(((__   __ \\   \                  `>,% (\  (\./)8X         ;:'  i   
)))--`.'-- (( ;,8 \               ,;%%%:  ./V^^^V'          ;.   ;.  
((\   |   /)) .,88  `: ..,,;;;;,-::::::'_::\   ||\         ;[8:   ;  
 )|  ~-~  |(|(888; ..``'::::8888oooooo.  :\`^^^/,,~--._    |88::  |  
 |\ -===- /|  \8;; ``:.      oo.8888888888:`((( o.ooo8888Oo;:;:'  |  
 |_~-___-~_|   `-\.   `        `o`88888888b` )) 888b88888PXX'     ;  
 ; ~~~~;~~         X`--_`.       b`888888888;(.,X888b888X  ..::;-'   
   ;      ;              ~X-....  b`8888888:::::.`8888. .:;;;''      
      ;    ;                 `:::. `:::OOO:::::::.`OO' ;;;''         
 :       ;                     `.      X``::::::''    .'             
    ;                           `.   \_              /               
  ;       ;                       +:   ~~--  `:'  -';                
                                   `:         : .::/                 
      ;                            ;;+_  :::. :..;;;                 
                                   ;;;;;;,;;;;;;;;,;                 
".Replace("X", "\"");

        private static readonly string TownArt = @"
                                 ____                                         
                              .-X    `-.      ,                               
                            .'          '.   /j\                              
                           /              \,/:/#\                /\           
                          ;              ,//' '/#\              //#\          
                          |             /' :   '/#\            /  /#\         
                          :         ,  /' /'    '/#\__..--XXXX/    /#\__      
                           \       /'\'-._:__    '/#\        ;      /#, XXX---
                            `-.   / ;#\']X ; XXX--./#J       ':____...!       
                               `-/   /#\  J  [;[;[;Y]         |      ;        
XXXXXX---....             __.--X/    '/#\ ;   X X  |     !    |   #! |        
             XX--.. _.--XX     /      ,/#\'-..____.;_,   |    |   '  |        
                   X-.        :_....___,/#} X####X | '_.-X,   | #['  |        
                      '-._      |[;[;[;[;|         |.;'  /;\  |      |        
                      ,   `-.   |        :     _   .;'    /;\ |   #X |        
                      !      `._:      _  ;   ##' .;'      /;\|  _,  |        
                     .#\XXX---..._    ';, |      .;{___     /;\  ]#' |__....--
          .--.      ;'/#\         \    ]! |       X| , XXX--./_J    /         
         /  '%;    /  '/#\         \   !' :        |!# #! #! #|    :`.__      
        i__..'%] _:_   ;##J         \      :X#...._!   '  X  X|__  |    `--.._
         | .--XXX !|XXXX  |XXX----...J     | '##XX `-._       |  XXX---.._    
     ____: |      #|      |         #|     |          X]      ;   ___...-XT,  
    /   :  :      !|      |   _______!_    |           |__..--;XXX     ,;MM;  
   :____| :    .-.#|      |  /\      /#\   |          /'               ''MM;  
    |XXX: |   /   \|   .----+  ;      /#\  :___..--XX;                  ,'MM; 
   _Y--:  |  ;     ;.-'      ;  \______/#: /         ;                  ''MM; 
  /    |  | ;_______;     ____!  |X##XXXMM!         ;                    ,'MM;
 !_____|  |  |X#X#X|____.'XX##X  |       :         ;                     ''MM 
  | XXXX--!._|     |##XX         !       !         :____.....-------XXXXXX |' 
  |          :     |______                        ___!_ X#XX#XX#XXX#XXX#XXX|  
__|          ;     |MMXMMXXXXX---..._______...--XXMMXMM]                   |  
  X\-.      :      |#                                  :                   |  
    /#'.    |      /##,                                !                   |  
   .',/'\   |       #:#,                                ;       .==.       |  
  /X\'#X\',.|       ##;#,                               !     ,'||||',     |  
        /;/`:       ######,          ____             _ :     M||||||M     |  
       ###          /;X\.__X-._   XXX                   |===..M!!!!!!M_____|  
                           `--..`--.._____             _!_                    
                                          `--...____,=X_.'`-.____             
".Replace("X", "\"");

        private static readonly string StoreArt = @"
O==|=======\|/====|======|=================|========|=============,|`======O
  ,;,     ;%|%;  ,|,   ,/|\`             ,/|\,     `;,   _       ,oOo,      
  ,;,    ;%%|%%; %|%   `@@@`           _ ;/|\;     ';'  [_]      oO\Oo      
   ; _    ;%|%;  %%%    '@'           (_) ;;;       `   | |      'o/o`      
    \=/    %|%   '%'     `    __      | |  ;   ___      | |       `o'       
    / \     %                )==(    /   \    |===|    /   \                
   |   |    '               /    \  |~~~~~|  /     \  |     |               
   |   |                   |      | |   //| |-------| |.....|   _______     
   |   |            __o__  |      | |     | |    ~~ | |     |  [_______]    
   |   | .------.  | *** | |      | |     | |       | |'''''|  |       |    
   |   | |      |  |     | |      | |     | | ~~    | |     |  |       |    
   |   | |      |  |     | |      | |//   | |-------| |//   |  |       |    
  _'---'_'------'__'-----'_'------'_'-----'_'-------'_'====='__'-------'__  
 [________________________________________________________________________] 
      |.|                  |.|                |.|                 |.|       
      |_|                  |_|                |_|                 |_|       
                                                                            
              o                                                             
              X                                                             
              X                           /| /\ |\                          
         |===[O]===|                     /(__)(__)\                         
             |||                        {  __<>__  }        (               
             |||       |`-._/\_.-`|      \(  ||  )/          \              
             |||       |    ||    |       \| || |/            )             
             |||       |___o()o___|          ||          ##-------->        
             |||       |__((<>))__|          ||               )             
             |||       \   o\/o   /          ||              /              
             |||        \   ||   /           ||             (               
             |||         \  ||  /            ||                             
             |||          '.||.'             ][                             
             |^|            ``               ][                             
             \ /                             ==                             
              `                                                             
";

        private const string InnArt = @"
_______________________________________________________________
                          .-|-|----------------|-|-.           
                          | .-. .-. .  .-. .-. . . |_          
                     .--~~| `-. |-| |  | | | | |\| | ~~--.     
                     |    | `-' ` ' `- `-' `-' ' ' |     |     
                     |    `-.____________________.-'     |     
_______________      |                                   |     
     |         |     |                                   |     
  /  |   /  /  |     |                                   |     
/    |     /   |     | _______                   _______ |     
_____|_________|     ||       ~---_         _---~       ||     
     |    /    |     ||           ~---. .---~           ||     
 / / |         |     ||               | |               ||     
  /  |  /   /  |     ||               | |               ||     
_____|_________|     ||               | |               ||     
---------------'     ||               |  |               ||    
                     ||               | |               ||     
                     ||               | |               ||     
                     ||           .---' `---.           ||     
                     |`.______.---'         `---.______.'|     
               ______|                                   |_____
---------------------------------------------------------------
";

        private const string InventoryArt = @"
            _....._                  
           ';-.--';'                 
             }===={       _.---.._   
           .'      '.    ';-..--';   
          /::        \    `}===={    
         |::          |  .:      '.  
         \::.         /_;:_        \ 
          '::_     _-;'--.-';       |
              `````  }====={        /
                   .'       '.   _.' 
                  /::         \``    
                 |::           |     
                 \::.          /     
                  '::_      _.'      
                      ``````         
";

        private const string SpellBookArt = @"
                .-~~~~~~~~~-._       _.-~~~~~~~~~-.                
            __.'              ~.   .~              `.__            
          .'//                  \./                  \\`.          
        .'//                     |                     \\`.        
      .'// .-~""""""""""""""~~~~-._     |     _,-~~~~""""""""""""""~-. \\`.      
    .'//.-""                 `-.  |  .-'                 ""-.\\`.    
  .'//______.============-..   \ | /   ..-============.______\\`.  
.'______________________________\|/______________________________`.
";

        public string GetTitleArt()
        {
            return TitleArt;
        }

        public string GetDungeonArt(int dungeonLevel)
        {
            return DungeonArt;
        }


        public string GetPlayerDeadArt(int dungeonLevel)
        {
            return PlayerDeadArt;
        }

        public string GetTownArt()
        {
            return TownArt;
        }

        public string GetStoreArt()
        {
            return StoreArt;
        }

        public string GetInnArt()
        {
            return InnArt;
        }

        public string GetInventoryArt()
        {
            return InventoryArt;
        }

        public string GetSpellBookArt()
        {
            return SpellBookArt;
        }
    }
}
