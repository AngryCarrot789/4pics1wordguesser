   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   F BFPOWGuesser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:FPOWGuesserFPOWGuesser 5   	      FPOWGuesser.MainWindow   5      HControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro  5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:FPOWGuesser     5   	   -   5          � Icon$"  alphabetical-sorting-128.ico��5       � 
ResizeMode$ CanResizeWithGrip=�6>    � Title$ 4Pics1Word Guesser��5	   	   $��604.528��6$   $��310.111��65   ���	#FF252525(   "MahApps.Metro.Controls.MetroWindow   WindowTitleBrush �	#FF464646   	GlowBrush �	#FF464646   NonActiveBorderBrush �	#FF555555���	#FF272727    NonActiveWindowTitleBrush �	#FF4F4F4F � DataContext 5
        FPOWGuesser.MainViewModel  5   
   .��5      � .+�5   
   o� $	��Top=�6   .@�5      m� $��Things��6   $��Consolas)�6'   .@�5      m� -   5         m�Name$ helpwin��5   0   $��Help Window��6   6A   5      5      �� 5   
   $��Begin��6C   $��
10,27,10,0q�6S   $	��Top=�6g   $��56��6   $��24(�6�   $��Consolas)�6�   ���	#FF444444��6   �� *generateWords.BeginGenerating+6�   �� 5   
   $��Letters:��6   $
��Left=�6#   $��	10,83,0,0q�6>   $	��Top=�6Q   $��Consolas)�6i   �� 5   
   $��32��69   $��10,107,10,0q�6E   	 �� TextWrapping$
	 Wrap=�6Z   $	��Top=�6n   $��16(�6�   $��Consolas)�6�   ���	#FF444444��6   �� *generateWords.Letters+6�   �� 5   
   $��8q�6   $��No. of Letters in Word:��6   $
��Left=�6>   $��
10,144,0,0q�6Y   $	��Top=�6m   $��32��6�   $��Consolas)�6�   *   $MahApps.Metro.Controls.NumericUpDown  5   
   
   Maximum$
 9Q�6u      Minimum$ 3Q�6�   $��32��6�   $��178,144,10,0q�6�   $	��Top=�6�   $��16(�6�   $��Consolas)�6�   ���	#FF444444   Value 6!   �� *generateWords.LettersNumbers+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��Match with Dictionary��6G   $
��Left=�6g   $��
10,176,0,0q�6�   $	��Top=�6�   $��Consolas)�6�   ���	#FF444444 d� 	IsChecked 6   �� *generateWords.AllowDictionary+6�   �� 5   
   -   5         ��Name$ LB��5   M   $��1q�69   $��10,199,10,201q�6  $��Consolas)�6P  ���	#FF444444 �� SelectedItem 6Y   �� *generateWords.SearchList+$ PropertyChanged=���6�   �� *!generateWords.PossibleWordsList+$ PropertyChanged=�6f  �� 5   
   $��Clear��6=   $��10,0,142,164q�6M   $��Bottom=�6c   $��32��6~   $��Consolas)�6�   ���	#FF444444��6   �� *generateWords.ClearList+6�   �� 5   
   $��Search:��6   $
��Left=�6"   $��
10,0,0,140q�6=   $��Bottom=�6Q   $��Consolas)�6l   �� 5   
   $��27��68   $��10,0,108,113q�6D   $
	 Wrap=�6Z   $��Bottom=�6n   $��Consolas)�6�   ���	#FF444444��6   �� *generateWords.Search+6�   �� 5   
   $��Search��6A   $��Right=�6R   $��
0,0,10,113q�6n   $��Bottom=�6�   $��93��6�   $��Consolas)�6�   $��27��6�   ���	#FF444444��6   �� *generateWords.SearchCommand+6�   �� 5   
   $��
Raw Words:��6   $
��Left=�6%   $��	10,0,0,89q�6@   $��Bottom=�6S   $��Consolas)�6n   �� 5   
   $��Real Words:��6   $
��Left=�6&   $��	10,0,0,65q�6A   $��Bottom=�6T   $��Consolas)�6o   �� 5    
   $
��Left=�6`   $��	93,0,0,89q�6{   $��Bottom=�6�   $��Consolas)�6�   ��6   �� *generateWords.RawWords+$ PropertyChanged=�6�   �� 5!   
   $
��Left=�6a   $��	93,0,0,65q�6|   $��Bottom=�6�   $��Consolas)�6�   ��6   �� *generateWords.RealWords+$ PropertyChanged=�6�   �� 5"   
    � ToolTip$3 -Opens a window with a listbox with every word��6D   $��Predefined Letters��6|   $��10,0,157,10q�6�   $��Bottom=�6�   $��31��6�   $��Consolas)�6�   ���	#FF444444��6   �� * generateWords.OpenHelpWinThing+6�   �� 5#   
   $C =The character that you know in the position (textbox to left)��6^   $��31��6�   $��	0,0,90,10q�6�   $
	 Wrap=�6�   $��Bottom=�6�   $��Right=�6�   $��62��6  $��16(�6  $��Consolas)�6)  ���	#FF444444��6   �� *generateWords.HelpWin+$ PropertyChanged=�6?  �� 5$   
   $��Predefined Letters:��6   $
��Left=�6.   $��	10,0,0,41q�6I   $��Bottom=�6\   $��Consolas)�6w   �� 5%   
   $��Letter:��6   $��Right=�6"   $��	0,0,90,41q�6>   $��Bottom=�6Q   $��62��6l   $��Consolas)�6w   �� 5&   
   $P JCharacter in the string. 0 is the first character. 5 is the 6th character.��6_   $��31��6�   $��	0,0,10,10q�6�   $
	 Wrap=�6�   $��Bottom=�6�   $��Right=�6  $��75��6  $��16(�6)  $��Consolas)�67  ���	#FF444444��6   �� *generateWords.HelpWint+$ PropertyChanged=�6M  �� 5'   
   $��
Pos (0-8):��6   $��Right=�6%   $��	0,0,10,41q�6A   $��Bottom=�6T   $��75��6o   $��Consolas)�6z   �� 5(   
   $��Delete Selected��6B   $��Right=�6\   $��
0,0,10,164q�6x   $��Bottom=�6�   $	��127��6�   $��32��6�   ���	#FF444444��6   �� *generateWords.DeleteSelected+6�   5*      5+      