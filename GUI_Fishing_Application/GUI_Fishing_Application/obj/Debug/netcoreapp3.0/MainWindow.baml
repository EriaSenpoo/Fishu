   M S B A M L   `   `   `  ����R  NGUI_Fishing_Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:GUI_Fishing_ApplicationGUI_Fishing_Application  5   	   (    "GUI_Fishing_Application.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:GUI_Fishing_Application     5   	     � Title$  Fishing Application��5   	   
�����w�$	��637��6A   $	��560��6N    � 
ResizeMode$ NoResize=�5	   	    � 	Resources 5
         Fish_CollectionViewSource �� CollectionViewType��%"   &	        �� 5   
   " ��6A   5      .��5      � .+�5   
   �� -   5         ��Name$ Header_text��5      $��Fishing Application��6%   $��Center=�6C   $��0,28,0,0q�6`   $	��Top=�6r   $��30(�6�   $��Heavy"�6�   
����=H�6�   �� 5   
   -   5         ��Name$ 
Log_border��5      $��5q�6%   
���   �$��203,107,30,24q�6M   ._�5      � -   5         �Name$ Inventory_grid��5       � RowDefinitions 5      �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$   �� 5      $��* �6$    � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   �� 5      $��* �6'   .+�5!      �� $��2��6   $��4��6,   
���  ��69   5"      5#      �� 5$   
   -   5        	 ��Name$	 Log_controller��5$      $��208,114,35,29q�6/   $y�Hidden=�6F   .@�5%      &   System.Windows.Controls.DataGrid  -   5        
  Name$
 DataGrid_log��5%       � DataContext# [  6-      AutoGenerateColumns$ False��6f   $��6��6�   $��7��6�      HeadersVisibility$ Column=�6�   ��6�   ��    Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$
 Fish��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67      
FontWeight$ Heavy"�6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *	fish_type+6_     5(      $ Value��6)   $ * 68   $ Heavy"�6a    6B   �� *
fish_value+6a   5*      5+      �� 5,   
   -   5         ��Name$ Button_fish��5,      $
��Fish��6&   $
��Left=�65   $��
35,107,0,0q�6P   $	��Top=�6d   $��40��6|   $	��130��6�   $��25(�6�   $��DemiBold"�6�   6�   �� 5-   
   -   5        $ 
Button_log��5-      $	��Log��6%   $
��Left=�63   $��
35,167,0,0q�6N   $	��Top=�6b   $��40��6z   $	��130��6�   $��25(�6�   $��DemiBold"�6�   6�   �� 5.   
   -   5        $ Button_inventory��5.      $��	Inventory��6+   $y�	Collapsed=�6?   $
��Left=�6V   $��
35,167,0,0q�6q   $	��Top=�6�   $��40��6�   $	��130��6�   $��25(�6�   $��DemiBold"�6�   6�   �� 5/   
   -	   5        $ Button_technique��5/      $��	Technique��6+   $
��Left=�6?   $��
35,227,0,0q�6Z   $	��Top=�6n   $��40��6�   $	��130��6�   $��25(�6�   $��DemiBold"�6�   6�   �� 50   
   -
   5        $ Technique_label��50   $   $��	Technique��6   $y�Hidden=�6=   $��Center=�6Q   $��	0,115,0,0q�6n   $	��Top=�6�   $��25(�6�   $��Heavy"�6�   �� 51   
   -   5        $ Bait_border��51      $y�Hidden=�6&   $��5q�6:   
���   �$��30,167,30,135q�6b   ._�52      � -   5        $ 	Bait_grid��52      $y�Hidden=�6&    53      �� 54      $��* �6$   �� 55      $��* �6$   �� 56      $��* �6$    58      �� 59      $��* �6'   �� 5:      $��* �6'   �� 5;      $��* �6'   �� 5<      $��* �6'   .+�5>      �� $��1��6   
����p��6,   5?      5@      �� 5A   
   -   5        $ Button_return��5A      $��Return��6(   $y�Hidden=�69   $��Center=�6M   $��	0,503,0,0q�6j   $	��Top=�6}   $��40��6�   $	��130��6�   $��25(�6�   $��DemiBold"�6�   6�   �� 5B   
   -   5        $ Button_sell_fish��5B      $��	Sell fish��6+   $
��Left=�6?   $��
35,287,0,0q�6Z   $	��Top=�6n   $��40��6�   $	��130��6�   $��25(�6�   $��DemiBold"�6�   6�   �� 5C   
   -   5        $ Fish_caught_label��5C      $��Fish caught��6+   $
��Left=�6A   $��
25,383,0,0q�6\   $	��Top=�6p   $��25(�6�   $��	ExtraBold"�6�   �� 5D   
   -   5        $ Money_label��5D      $��Money��6%   $
��Left=�65   $��
53,485,0,0q�6P   $	��Top=�6d   $��25(�6|   $��	ExtraBold"�6�   �� 5E   
   -   5         ��Name$ Fish_caught��5E      $
��Left=�6)   $��
85,431,0,0q�6D   $	��int��6X   $
��Wrap=�6c   $	��Top=�6w   $��25(�6�   $��DemiBold"�6�   �� 5F   
   -   5        $ Money��5F      $
��Left=�6#   $��
85,533,0,0q�6>   $	��int��6R   $
��Wrap=�6]   $	��Top=�6q   $��25(�6�   $��DemiBold"�6�   5G      5H      