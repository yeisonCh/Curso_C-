   M S B A M L   `   `   `  ����F  BRadioButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:RadioButtonRadioButton  5   	       RadioButton.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:RadioButton     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��150 �6   6+   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   .+�5      �� $��SEMAFORO��6   $��30(�6(    �� TextAlignment$ Center=�66   
����+��6g   5      �� 5   
   $��1��6   .+�5      �  � ColumnDefinitions 5      �� 5      $
��0.5* �6'   66   �� 5      $
��0.5* �6'   66   .+�5      �� $��0��6   .+�5      	� -   5        $��
50,5,30,40q�5   "   .��5      �� $
��Rojo��6$   62   5      	� 5      -   5        $��
50,5,30,40q�5   "   .��5      �� $��Amarillo��6$   66   5       	� 5!      -   5        $��
50,5,30,40q�5!   "   .��5"      �� $��Verde��6$   63   5#      5&      � 5'      $��1��6   .+�5(      �� $��D:\Documents\semafaro.jpg��6   $	��221��6?   $��
125,0,84,0q�6L   � 5*      .+�5+      A� -   5        $
��rojo��5+   "   
���  ��$��202,22,165,174q�69    J� RenderTransformOrigin$ 0.917,0.062&�6Q   $y�Hidden=�6u   A� 5,      -   5        $��amarillo��5,   "   
��� ���$��202,56,165,140q�6@   $ 0.917,0.062&�6X   $y�Hidden=�6|   A� 5-      -   5        $��verde��5-   "   
��� � �$��201,92,166,104q�6<   $ 0.917,0.062&�6T   $y�Hidden=�6x   5.      50      53      56      57      58      