   M S B A M L   `   `   `  ����?  ;kurs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:kurskurs  5          kurs.Profile   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:kurs     5        N� Title$  Profile��5	      .��5
      ��  �� CornerRadius$ 20,0,0,0��6   ���#121129$��	0,0,0,-73q�6:   ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��400 �6#   �� 5      .+�5      �� $��
52,44,0,32q�6   $
��Left=�6-   .+�5      �� $��0��6   $��
Логин��5      
�������$��	0,0,130,0q�5      $��15(�5      $
��Left=�5      $	��Top=�5      �� 5      $��1��6   $	��300��6&   $��40��5      $��Center=�5      $	��Top=�5      $��0,10,0,0q�5      $ 10��5      ���#1F2949._�5      � .+�5       �� $��1��6$   �� 5!      -   5         ��Name$ LoginTb��5(   &   $��1q�5!   "   $��0q�5"   ;   
������ $��Center=�5$   &   $��5q�5%   &   ���#CFCFCF��5'   &   �� *
User.Login+.��5(   H   5*      �� 5+       J� IsHitTestVisible .  $��Center=�5,   (   $
��Left=�5-   (   $��10,0,0,0q�5.   (   $��11(�5/   (   
�������$��1��51   (   ��53      �� 54   "    �� 
TargetType" ��6(    �� Triggers 55   &   �� 56   *    �� Binding 66   �� *Text+ �� ElementName$ LoginTb��	 �� Value	  6e   .a�57   .   �� 
 �� Property
 � y� �� Value$ Visible=�6K   6]   58   +   .�5:   &   �� 
 � y�$ 	Collapsed=�6C   6W   5;   #   5=      5>      5?      �� 5A      $��0��6   $��Имя��5B      
�������$��
0,10,150,0q�5D      $��15(�5E      $
��Left=�5F      $	��Top=�5G      �� 5J      $��1��6   $	��300��6&   $��40��5K      $��Center=�5L      $	��Top=�5M      $��0,10,0,0q�5N      $ 10��5O      ���#1F2949._�5Q      � .+�5R      �� $��1��6$   �� 5S      -   5        $ NameTb��5Z   &   $��1q�5S   "   $��0q�5T   ;   
������ $��Center=�5V   &   $��5q�5W   &   ���#CFCFCF��5X   &   �� *Name+.��5[   '   5]      �� 5^       .  $��Center=�5_   (   $
��Left=�5`   (   $��10,0,0,0q�5a   (   $��11(�5b   (   
�������$��1��5d   (   ��5f      �� 5g   "   " ��6(    5h   &   �� 5i   *    66   �� *Text+$ LoginTb��	  6e   .a�5j   .   �� 
 � y�$ Visible=�6K   6]   5k   +   .�5m   &   �� 
 � y�$ 	Collapsed=�6C   6W   5n   #   5p      5q      5r      �� 5s      $��0��6   $��Фамилия��5t      
�������$��
0,10,130,0q�5v      $��15(�5w      $
��Left=�5x      $	��Top=�5y      �� 5|      $��1��6   $	��300��6&   $��40��5}      $��Center=�5~      $	��Top=�5      $��0,10,0,0q�5�      $ 10��5�      ���#1F2949._�5�      � .+�5�      �� $��1��6$   �� 5�      -   5        $ SecondNameTb��5�   &   $��1q�5�   "   $��0q�5�   ;   
������ $��Center=�5�   &   $��5q�5�   &   ���#CFCFCF��5�   #   �� *
SecondName+.��5�   '   5�      �� 5�       .  $��Center=�5�   (   $
��Left=�5�   (   $��10,0,0,0q�5�   (   $��11(�5�   (   
�������$��1��5�   (   ��5�      �� 5�   "   " ��6(    5�   &   �� 5�   *    66   �� *Text+$ LoginTb��	  6e   .a�5�   .   �� 
 � y�$ Visible=�6K   6]   5�   +   .�5�   &   �� 
 � y�$ 	Collapsed=�6C   6W   5�   #   5�      5�      5�      �� 5�      $��0��6   $��Отчество��5�      $��15(�5�      
�������$��
0,10,130,0q�5�      $
��Left=�5�      $	��Top=�5�      �� 5�      $��1��6   $	��300��6&   $��40��5�      $��Center=�5�      $	��Top=�5�      $��0,10,0,0q�5�      $ 10��5�      ���#1F2949._�5�      � .+�5�      �� $��1��6$   �� 5�      -   5        $ 
LastNameTb��5�   &   $��1q�5�   "   $��0q�5�   ;   
������ $��Center=�5�   &   $��5q�5�   &   ���#CFCFCF��5�   &   �� *
LastName+.��5�   '   5�      �� 5�       .  $��Center=�5�   (   $
��Left=�5�   (   $��10,0,0,0q�5�   (   $��11(�5�   (   
�������$��1��5�   (   ��5�      �� 5�   "   " ��6(    5�   &   �� 5�   *    66   �� *Text+$ LoginTb��	  6e   .a�5�   .   �� 
 � y�$ Visible=�6K   6]   5�   +   .�5�   &   �� 
 � y�$ 	Collapsed=�6C   6W   5�   #   5�      5�      5�      �� 5�      $��0��6   $��Телефон��5�      
�������$��
0,10,130,0q�5�      $��15(�5�      $
��Left=�5�      $	��Top=�5�      �� 5�      $��1��6   $	��300��6&   $��40��5�      $��Center=�5�      $	��Top=�5�      $��0,10,0,0q�5�      $ 10��5�      ���#1F2949._�5�      � .+�5�      �� $��1��6$   �� 5�      -   5        $ PhoneTb��5�   &   $��1q�5�   "   $��0q�5�   ;   
������ $��Center=�5�   &   $��5q�5�   &   ���#CFCFCF��5�   &   �� *Phone+.��5�   '   5�      �� 5�       .  $��Center=�5�   (   $
��Left=�5�   (   $��10,0,0,0q�5�   (   $��11(�5�   (   
�������$��1��5�   (   ��5�      �� 5�   "   " ��6(    5�   &   �� 5�   *    66   �� *Text+$ LoginTb��	  6e   .a�5   .   �� 
 � y�$ Visible=�6K   6]   5  +   .�5  &   �� 
 � y�$ 	Collapsed=�6C   6W   5  #   5     5     5     �� 5     -   5         ��Name$ btnSave��5     $	��120��5     $��40��5     $��Center=�5     $
��Left=�5     ���	#ff1d222c
�������$��Сохранить��5     $��18(�5     $��0,20,0,0q�5     ��5     �� 5     " ��6    .�5     �� 
 � �� �#a0a0a06;   �� 5     
 � �� 5  "   �� 5  &    �� 
TargetType" ��66   .R�5  *   ��  ��Name$ ButtonBackground��61   
�������._�5   .   �� $��Center=�6?   $��Center=�6Z   $��0q�5!  _   $ 10��5"  Z   ��5#  .   �� 5$  2    �� EndPoint$ 0.5,1&�6F    �� 
StartPoint$ 0.5,0&�6W   .��5%  6   �  � Color$ #24397C��6C    � Offset$ 0Q�6S   � 5&  6   $ #24397C��6C   $ 1Q�6S   5'  3   5)  +    �� Triggers 5*  *   P� 5+  .    P� Property �@J�IsMouseOver P� Value . . �5,  2   ��  �� 
TargetName$ ButtonBackground��69   
 � �� 5-  6   �� 5.  :   $ 0.5,0&�6N   $ 0.5,1&�6a   .��5/  >   � $ 	#ff232d3e��6K   $ 0Q�6]   � 50  >   $ 	#ff232d3e��6K   $
 0.75Q�6]   � 51  >   $ 	#ff232d3e��6K   $
 0.75Q�6]   � 52  >   $ 	#ff232d3e��6K   $ 1Q�6]   53  ;   55  3   56  /   59  '   5;     5<     5>     5@     �� 5B     $��1��6   ���#1F2949$ 20��5D     $	��450��5E     $	��300��5F     $��Center=�5G     $��0,0,0,40q�5H     ._�5I     �  � RowDefinitions 5J     �� 5K     $	��200 �6(   �� 5L     .+�5N     �� $��0��6!   .+�5O     A� $��	0,10,0,10q�6"   $	��150��66   $	��150��6B   $��0��5P     ��5Q     �� 5R  "   -   5        	LoadImage�� �� ImageSource 5R  @   �� *	ImagePath+5T     �� 5V     -   5         ��Name$ 
NickNameTb��5X  $   
�������$��20(�5W  $   $��Center=�5Z  $   ��5Y  $   �� *
User.Login+5Z  C   5[     �� 5^     $��1��6!   .+�5`     	� -	   5        $��Аккаунт��5`  &   $��50��5a     $��0,2,0,0q�5c  &   
�������$��14(�5e        MenuButtonTheme#��[  5f     6G   	� 5i     $%��Изменение пароля��6&   $��50��5j     $��0,2,0,0q�5k  &   
�������$��14(�5n     #��[  5o     	� 5s     -
   5        $%��Смена фотографии��5s  &   $��50��5t     $��0,2,0,0q�5u  &   
�������$��14(�5x     #��[  5y     6G   	� 5{     -   5        $'��!Удаление аккаунта��5{  &   $��50��5|     $��0,2,0,0q�5}  &   
�������$��14(�5�     #��[  5�     6G   	� 5�     -   5        $&�� Выход из аккаунта��5�  &   $��50��5�     $��0,2,0,0q�5�  &   
�������$��14(�5�     #��[  5�     6G   5�     5�     5�     5�     5�     5�     