   M S B A M L   `   `   `  ����N  JColour Guessing App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Colour_Guessing_AppColour_Guessing_App  5   	   $    Colour_Guessing_App.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Colour_Guessing_App     5   	     � Title$  
HexGuesser��5   	   $	��450��6   $	��800��6)   .��5	      � ���	#FF202020.+�5
   
   �� -   5        $��rectangleForColour��5
   1   $��Center=�6   $	��132��6L   $��0,51,0,0q�6Y   
���   �$	��Top=�6z   $	��692��6�   
�������6�   �� 5   
   -   5         ��Name$ btnGuess��5      $��Guess��6#   $��Center=�63   $��	0,306,0,0q�6P   $	��Top=�6c   
����������	#FF202020
�������$��22(�6�   $��	10,1,10,1q�6�   �� 5   
   -   5         ��Name$ txtGuess��5      $��Center=�6$   $��	0,235,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��120��6�   6�   �� 5   
   -   5         ��Name$ 	txbResult��5      $��Center=�6'   $��	0,345,0,0q�6D   $
��Wrap=�6W   $��48��6k   $	��Top=�6w   $	��302��6�    �� TextAlignment$ Center=�6�   ���	#FF202020
�������6�   �� 5   
   -   5        $ btnTryAgain��5      $��	Try again��6&   $��Center=�6:   $��	0,309,0,0q�6W   $	��Top=�6j   ���	#FF202020
�������
�������$��18(�6�   $��	10,1,10,1q�6�   6�   �� 5   
   -   5         ��Name$ label��5      $��Guess the above colour��6   $��Center=�6@   $��	0,188,0,0q�6]   $	��Top=�6p   
�������$��16(�6�   �� 5   
   -   5        $ label1��5      $��Your current guess��6    $
��Left=�6=   $��616,259,0,0q�6X   $	��Top=�6m   
�������$��15(�6�   �� 5   
   -   5         ��Name$ rectCurrentGuessColour��5      $
��Left=�64   $��76��6O   $��619,183,0,0q�6[   
���   �$	��Top=�6   $	��127��6�   5      5      