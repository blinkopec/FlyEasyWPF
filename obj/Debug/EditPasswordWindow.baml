   M S B A M L   `   `   `  ����I  EintegrationWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:integrationWPFintegrationWPF  5   	   '    !integrationWPF.EditPasswordWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:integrationWPF     5   	     � Title$  FlyEasy��5   	   $	��200��6   $	��250��6&    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � 	Resources 5       	  Icons �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 �� Triggers
 :� RoutedEvent �� TargetProperty g� Duration	 t� To�� 5   
   %  &	        �� 5      " ��6"   .�5      ��  �@�OverridesDefaultStyle . 6:   �� 5       � ��
 ���� 6/   �� 5       � �� 5      �� 5      " ��6*   .R�5      �� $��Border��67   $ 20��6%   #��z��6E   ._�5   "   �� $��Center=�63   $��Center=�6P   5      	 5      :� 5   "   $
 
MouseEnter��6/   .[�5   &   �� .��5   *   �� .��5   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 2,2,2,2X�6y   5   +   5   '   5   #   :� 5   "   $
 
MouseLeave��6/   .[�5    &   �� .��5!   *   �� .��5"   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 1,1,1,1X�6y   5#   +   5$   '   5%   #   :� 5&   "   $
 PreviewMouseDown��6/   .[�5'   &   �� .��5(   *   �� .��5)   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 4,4,4,4X�6y   5*   +   5+   '   5,   #   :� 5-   "   $
 PreviewMouseUp��6/   .[�5.   &   �� .��5/   *   �� .��50   .   t� $ Margin�6A   $ 	0:0:0.100D�6d   $ 0,0,0,0X�6y   51   +   52   '   53   #   55      57      58      5:      .��5=      �  � ColumnDefinitions 5>   
   �� 5?      $	��130 �6   �� 5@       � RowDefinitions 5B   
   �� 5C      $��28 �6   �� 5D      �� 5E      $��30 �6   �� 5F      $��30 �6   �� 5G      .+�5K   
   �� $��28��6   $��35��6   $
��Left=�6(   $��0��6D   ._�5L      �� -   5         ��Name$ 
BackButton��5L       � Cursor$
 Hand��6)   #��[  67   .��5M      ��  �� Orientation$ 
Horizontal=�6   .+�5N      �� ��5O      �� 5P      " ��6$   .�5Q   "   ��  � ��$ Resources/back-icon.png��6;    �� Triggers 5R   "   �� 5S   &    �� Binding 62   ��  �� Path$ IsMouseOver� �� ElementName$
 Cart�� �� Value True6i   .a�5T   *   ��  � ��$ Resources/back-icon.png��6C   5U   '   �� 5V   &    62   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" �� �� AncestorLevel$ 1��$ 	IsPressed� True6�   .a�5W   *   ��  � ��$ Resources/back-icon.png��6C   5X   '   5Z      5\      5]      5^      5_      �� 5`   
   $��1��6   $��0��6   $��2��6-   $��Center=�6A   $��Center=�6\   $��Смена пароля��6y   $��26(�6�   $
��Bold"�6�   �� 5b   
   $��2��6   $��0��6   $(��"Предыдущий пароль:��6-   $��Right=�6J   �� 5c   
   $��3��6   $��0��6   $��Right=�6-   $��Новый пароль:��6I   G� 5e   
   -   5         G�Name$ LastPasswordBox��5e      $
��Left=�6/   $	��120��6J   $��2��6V   $��1��6c   G� 5f   
   -   5        $ NewPasswordBox��5f      $
��Left=�6.   $	��120��6I   $��3��6U   $��1��6b   �� 5h   
   -   5        $ 
SaveButton��5h      $��4��6>   $	��100��6K   $��0��6W   $��2��6g   $��30��6{   $��Сохранить��6�   5i      5j      