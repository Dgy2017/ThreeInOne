   M S B A M L   `   `   `  ����E  AThreeInOne, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ThreeInOne
ThreeInOne  5   	       ThreeInOne.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ThreeInOne     5   	   -   5          � AllowsTransparency  . 
������  � Title$ 
MainWindow��5
   	   $	��350��6   $	��525��6)    � WindowStyle$
 None=�6b    � Icon$A ;resource/Game_boy_51.80487804878px_1198279_easyicon.net.png��6u   .��5      � 
������ .+�5   
   ��    panel-default#��[  6   .��5      �� .+�5      ��  �� CornerRadius$ 	10,10,0,0��6   ._�5      � -   5        $��30��5      ���#4C9CFB$��
0,0,-0.4,0q�6\   .+�5      �� -   5         ��Name$ txtTitle��5   $   $��1,0,0,0q�66    �� Padding$ 5,3,2,3q�6H   $��
ThreeInOne��6Z   $
��Left=�5   $   $��Center=�6?   $��14(�6Z   $��微软雅黑)�6h   
�������5   $   �� 5      -   5         ��Name$ 	returnBtn��5   "   $��15��65   $��15��6@   $��Right=�6M   $��	10,0,35,0q�6�    � ToolTip$ 返回��6�   ��5      � 5   "   .+�5   &   �� $
��Fill=�6,   $1��+resource\back_24px_1199464_easyicon.net.png��6;   4  .System.Windows.Automation.AutomationProperties	   HelpText$	 返回��6p   5   #   ��5      �� 5   "   
 �� 
TargetType"
 ��62   .R�5   &   �� $�� {�60   �� 5   *   5   '   5   #   ��5       �� 5!   "    �� 
TargetType" ��6(   .�5"   &   ��  �� Property � �� �� Value �#128BE26C    �� Triggers 5#   &   P� 5$   *    P� Property �@J�IsMouseOver P� Value . . �5%   .   ��  � �� �#108EE96K   5&   +   5(   #   5*      �� 5+      -   5        $��15��5+   #   $��15��6.   $
��10,0q�6:   $��Right=�6H   $ 关闭��6z   ��5,      �� 5-   "   ._�5.   &   �� $
��Fill=�6,   $2��,resource\close_24px_1199468_easyicon.net.png��6;   5/   #   ��52      �� 53   "   "
 ��62   .R�54   &   �� $�� {�60   �� 55   *   56   '   57   #   ��59      �� 5:   "   " ��6(   .�5;   &   ��  � �� �#128BE26C    5<   &   P� 5=   *    �@J�IsMouseOver . . �5>   .   ��  � �� �#108EE96K   5?   +   5A   #   5C      �� 5D      -   5        $
 save��5D   !   $��15��61   $��15��6<   $
��60,0q�6H   $��Right=�6V   $ 保存进度��6�   ��5E      �� 5F   "   ._�5G   &   �� $
��Fill=�6,   $8��2resource\save_floppy_24px_1187937_easyicon.net.png��6;   5H   #   ��5K      �� 5L   "   "
 ��62   .R�5M   &   �� $�� {�60   �� 5N   *   5O   '   5P   #   ��5R      �� 5S   "   " ��6(   .�5T   &   ��  � �� �#128BE26C    5U   &   P� 5V   *    �@J�IsMouseOver . . �5W   .   ��  � �� �#108EE96K   5X   +   5Z   #   5\      �� 5]      -   5        $ recovery��5]   !   $��15��65   $��15��6@   $
��85,0q�6L   $��Right=�6Z   $ 载入进度��6�   ��5^      �� 5_   "   ._�5`   &   �� $
��Fill=�6,   $:��4resource\data_recovery_24px_1101416_easyicon.net.png��6;   5a   #   ��5d      �� 5e   "   "
 ��62   .R�5f   &   �� $�� {�60   �� 5g   *   5h   '   5i   #   ��5k      �� 5l   "   " ��6(   .�5m   &   ��  � �� �#128BE26C    5n   &   P� 5o   *    �@J�IsMouseOver . . �5p   .   ��  � �� �#108EE96K   5q   +   5s   #   5u      5v      5w      �� 5x      -   5         ��Name$
 body��5x   !     
panel-body#��[ 6/   $	��316��6S   $��0q�6`   $��0q�6k   5y      5z      5{      5|      