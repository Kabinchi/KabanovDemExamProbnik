   M S B A M L   `   `   `  ����S  OKabanov_DemExam_18052025, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Kabanov_DemExam_18052025Kabanov_DemExam_18052025  5   	   )    #Kabanov_DemExam_18052025.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Kabanov_DemExam_18052025     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�6.    � Title$ Клиенты��5	   	   $	��450��6   $	��800��6&   .��5
      �� $
��Auto=�6   .��5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��0��6   $��5q�6&    �� Orientation$ 
Horizontal=�61   $
��Left=�6J   .+�5      �� $��Images/пицца.png��6   $��50��62   5      �� 5      $��0��6   $��5q�6&   $ 
Horizontal=�61   $��Right=�6J   .+�5      �� ���#67BA80$��Добавить��6.   
�������$��5q�6T   $	��100��6_   �� 5      ���#67BA80$#��История заказов��6.   
�������$��5q�6[   $	��100��6f   5      �� 5      -   5         ��Name$ ClientsListView��5      $��1��6P   ��60   �� *	Clients+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ Stretch=�6G   5      ��5!      �� 5"      .R�5#      �� ���#F4E8D3$��1q�66   
���   �._�5%      � $��5q�6#   	 � ColumnDefinitions	 5&   "   �� 5'   &   $��* �67   �� 5(   &   $
��Auto �67   .+�5+   "   �� $��0��6-   $ 
Horizontal=�6=   .+�5,   &   �� ��60   �� *	Telephone+5-   #   �� 5/   "   51   #   52      53      54      56      57      58      59      