   M S B A M L   `   `   `  ����H  DFitnessCenter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Fclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Abonements8FitnessCenter.Views.Windows.Main.UserControls.Abonements  5      I)clr-namespace:FitnessCenter.BD.EntitiesBDFitnessCenter.BD.EntitiesBD  5	      L    FFitnessCenter.Views.Windows.Main.UserControls.Abonements.AbonementItem   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      XlocalFclr-namespace:FitnessCenter.Views.Windows.Main.UserControls.Abonements     5      7m)clr-namespace:FitnessCenter.BD.EntitiesBD     5	      .��5      �   � RowDefinitions  5   
   �� 5      $
��0.4* �6   �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $��40(�6   $��Center=�6"   $��Center=�6?   $��0��6Z   
���   �
���������6�   �� *Name+� 5   
   $��1��6    5      �� 5      �� 5      .+�5"      � $��0��6     5#      �� 5$      �� 5%      $
��0.4* �6$   .+�5(      �� $��0��6   .+�5*      �� $��20q�6!   $��Center=�6-    �� Orientation$ 
Horizontal=�6H   .+�5+      �� 
���   �$��30��67   $��30��6B   �� 5,      $	��100��6    $��Возраст:��6,   �� 5-      
���/���$��Center=�6=   $��Center=�6X   $	��100��6u   ��6�   �� *Age+5.      �� 50      $��20q�6!   $��Center=�6-   $ 
Horizontal=�6H   .+�51      �� 
���   �$��30��67   $��30��6B   �� 52      $	��100��6    $ ��Срок действия:��6,   �� 53      
���/���$��Center=�6=   $��Center=�6X   $	��100��6u   ��6�   �� *
Validity+54      �� 56      $��20q�6!   $��Center=�6-   $ 
Horizontal=�6H   .+�57      �� 
���   �$��30��67   $��30��6B   �� 58      $	��100��6    $$��Время посещения:��6,   �� 59      
���/���$��Center=�6=   $��Center=�6X   $	��100��6u   ��6�   �� *VisitingTime+5:      5<      � 5>      $��1��6     5?      �� 5@      $
��0.3* �6(   �� 5A      .+�5D      �� $��0��6    $��Включено:��6-   �� 5Y      $��1��6   
������ ��6D   �� *
Services+ �� UpdateSourceTrigger$ PropertyChanged=���5[      �� 5\      .R�5]   "   �� $ 
Horizontal=�6-   5^      ��5a      �� 5b      .R�5c   "   �� $��10q�6-   .+�5d   &   �� $��50��6E   $��50��6P   ��6,   �� *Phote+6P   �� 5e   &   ��60   �� *Title+5f   #   5g      5i      5j      5k      �� 5m      $��1��6   .+�5v      �� $��20q�6   $ 
Horizontal=�6)   .+�5w      �� $��10q�6   $��Стоимость:��6(   �� 5x      $��Center=�6    ��6;   �� *Price+�� 5y      $��10q�6    $��Center=�6,   $��рублей��6G   5z      �� 5|      $��20q�6   $	��400��6$   $	��200��60   ��6=   �� *Photo+5~      5      5�      5�      