   M S B A M L   `   `   `  ����I  EintegrationWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:integrationWPFintegrationWPF  5   	   &     integrationWPF.EditProfileWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:integrationWPF     5   	     � Title$  FlyEasy��5   	   $	��400��6   $	��400��6&    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 	Resources 5       	  Icons �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 �� Triggers
 :� RoutedEvent �� TargetProperty g� Duration	 t� To�� 5   
   %  &	        �� 5      " ��6"   .�5      ��  �@�OverridesDefaultStyle . 6:   �� 5       � ��
 ���� 6/   �� 5       � �� 5      �� 5      " ��6*   .R�5      �� $��Border��67   $ 20��6%   #��z��6E   ._�5   "   �� $��Center=�63   $��Center=�6P   5      	 5      :� 5   "   $
 
MouseEnter��6/   .[�5   &   �� .��5   *   �� .��5   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 2,2,2,2X�6y   5   +   5   '   5   #   :� 5    "   $
 
MouseLeave��6/   .[�5!   &   �� .��5"   *   �� .��5#   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 1,1,1,1X�6y   5$   +   5%   '   5&   #   :� 5'   "   $
 PreviewMouseDown��6/   .[�5(   &   �� .��5)   *   �� .��5*   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 4,4,4,4X�6y   5+   +   5,   '   5-   #   :� 5.   "   $
 PreviewMouseUp��6/   .[�5/   &   �� .��50   *   �� .��51   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 0,0,0,0X�6y   52   +   53   '   54   #   56      58      59      5;      .��5>      �  � ColumnDefinitions 5?   
   �� 5@      �� 5A      .+�5D   
   ��  �� Orientation$ Vertical=�6   $��0��6,   .+�5E      �� -   5         ��Name$ ImageProfile��5E      $	��200��6*   $	��200��66   �� 5F      -   5         ��Name$ EditImageProfileButton��5F      $	��150��6Z   $��0,30,0,0q�6f   $)��#Сменить фотографию��6x   �� 5G      -   5        $ EditPasswordButton��5G      $	��150��61   $#��Изменить пароль��6^   $��0,15,0,0q�6x   �� 5I      $��28��6   $��35��6!   $
��Left=�6,   $��0,50,0,0q�6H   ._�5J      �� -   5        $ 
BackButton��5J       � Cursor$
 Hand��6-   #��[  6;   .��5K      �� $ 
Horizontal=�6!   .+�5L      �� ��5M      �� 5N   "   " ��6(   .�5O   &   ��  � ��$ Resources/back-icon.png��6?    �� Triggers 5P   &   �� 5Q   *    �� Binding 66   ��  �� Path$ IsMouseOver� �� ElementName$
 Cart�� �� Value True6m   .a�5R   .   ��  � ��$ Resources/back-icon.png��6G   5S   +   �� 5T   *    66   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� AncestorLevel$ 1��$ 	IsPressed� True6�   .a�5U   .   ��  � ��$ Resources/back-icon.png��6G   5V   +   5X   #   5Z      5[      5\      5]      5^      �� 5`   
   $ Vertical=�6   $��1��6,   $��0,30,0,0q�6=   .+�5a      �� $ 
Horizontal=�6   .+�5b      �� $��Имя:��6   $��16(�6'   �� 5c      -   5         ��Name$ NameBox��5c      $	��120��6+   $��30��67   $��35,0,0,0q�6C   5d      �� 5e      $ 
Horizontal=�6   $��0,20,0,0q�62   .+�5f      �� $��Фамилия:��6   $��16(�6+   �� 5g      -   5        $ 
SurnameBox��5g      $	��120��6.   $��30��6:   5h      �� 5i      $ 
Horizontal=�6   $��0,20,0,0q�62   .+�5j      �� $��Отчество:��6   $��16(�6,   �� 5k      -   5        $ MiddlenameBox��5k      $	��118��61   $��30��6=   5l      5m      5n      5o      