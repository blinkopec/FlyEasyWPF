   M S B A M L   `   `   `  ����I  EintegrationWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:integrationWPFintegrationWPF  5   	       integrationWPF.UserWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:integrationWPF     5   	     � Title$  FlyEasy��5   	   $	��400��6   $	��400��6&    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
       � 	Resources 5       	  Icons �� 
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
 PreviewMouseUp��6/   .[�5/   &   �� .��50   *   �� .��51   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 0,0,0,0X�6y   52   +   53   '   54   #   56      58      59      5;      .��5>      �  � RowDefinitions 5?   
   �� 5@      $��28 �6   �� 5A       � ColumnDefinitions 5D   
   �� 5E      $	��200 �6   �� 5F      .+�5I   
   A�  K� ZIndex$ 0��6   ���#0154c5$��2��62   $��-64,-55,-67,182q�6F   $��2��6_    J� RenderTransformOrigin$ 0.5,0.5&�6p   z�5J      V� 5K      .~�5L      �� �� 5M       �� AngleX$ -2.045Q�6$   �� 5N       �� Angle$ -0.007Q�6&   T� 5O       T� X$ -2.464Q�6)   5P      5R      �� 5T   
   $��28��6   $��35��6   $
��Left=�6(   $	��Top=�6D   $��0��6]   $��0��6k   ._�5U      �� -   5         ��Name$ 
BackButton��5U       � Cursor$
 Hand��6)   #��[  67   .��5V      ��  �� Orientation$ 
Horizontal=�6   .+�5W      �� ��5X      �� 5Y      " ��6$   .�5Z   "   ��  � ��$ Resources/back-icon.png��6;    �� Triggers 5[   "   �� 5\   &    �� Binding 62   ��  �� Path$ IsMouseOver� �� ElementName$
 Cart�� �� Value True6i   .a�5]   *   ��  � ��$ Resources/back-icon.png��6C   5^   '   �� 5_   &    62   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� AncestorLevel$ 1��$ 	IsPressed� True6�   .a�5`   *   ��  � ��$ Resources/back-icon.png��6C   5a   '   5c      5e      5f      5g      5h      �� 5k   
   $	��200��6   $	��350��6!   $	��Top=�6.   $��Center=�6F   $ Vertical=�6c   $��0��6z   $��1��6�   .+�5l      �� -   5          ��Name$  ImageProfile��5l      $	��195��6*   $	��195��66   �� 5m      -   5        ! ��Name$! 	NameLabel��5m      $��24(�6'   $
��Bold"�66   �� 5n      -   5        $! SurnameLabel��5n      $��24(�6*   $
��Bold"�69   �� 5o      -   5        $! MiddlenameLabel��5o      $��24(�6-   $
��Bold"�6<   5p      �� 5r   
   $ Vertical=�6   $��1��6,   $��1��69   .+�5s      �� -   5        $ EditProfileButton��5s      $/��)Редактировать профиль��6P   $	��150��6p   $��0,30,0,0q�6|   �� 5t      -   5        $ MyRoutesButton��5t      $��Мои рейсы��6J   $	��150��6^   $��0,30,0,0q�6j   5u      5v      5w      