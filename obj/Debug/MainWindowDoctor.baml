   M S B A M L   `   `   `  ����G  CDentalClinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DentalClinicDentalClinic  5   	   #    DentalClinic.MainWindowDoctor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   &localclr-namespace:DentalClinic  5   	     � Title$  MainWindowDoctor��5	   	   $	��550��6"   $
��1300��6/   $��Bahnschrift)�6<   .��5
      � ���	#FFFFD5B8 � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��5 �6   �� 5      $��7* �6   .+�5   
   �� $��0��6   ���	#FF0A1129$��10q�6<   $��Stretch=�6H   .+�5      �� -   5        $��PatientList��5      $��10q�6*   $��Stretch=�66   ��5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6%   $��5q�6<   ��5      �� 5   "    �� 
TargetType" ��6(   .�5   &   ��  �� Property � {� �� Value . 6B   �� 5   &    �@J�Opacity$ 1Q�6@    �� Triggers 5   &   �� 5   *    �� Binding 66   �� *	status_id+ �� Value 26T   .a�5   .   ��  � {� .  6J   �� 5   .    �@J�Opacity$	 0.5Q�6H   5    +   5"   #   .+�5%      �� $
��Bold"�6F   $��11(�6X   
���������6(   �� *patient_name+6f   �� 5&      $��Italic$�6h   $��0,5,0,10q�6{   $��11(�6�   
���������6(   �� *appointment_time+	 �� StringFormat$	 
{0:hh\:mm}��6�   �� 5(      $ 
Horizontal=�6)   $��Right=�6B   .+�5*   "   �� 
 ��Name$
 CancelAppointmentButton��6)   -   5        $!��Отменить прием��5*   J   $	��5,0q�6c   $��11(�6p   
���  �����	#FFC20000��5+   &   �� 5,   *   " ��60   .�5-   .   ��  � y�$ 	Collapsed=�6K    5.   .   �� 5/   2    6>   �� *	status_id+ 16\   .a�50   6   ��  � y�$ Visible=�6S   51   3   53   +   55   #   �� 58   "   $
 StartAppointmentButton��6)   -   5        $��Начать прием��58   I   $	��5,0q�6`   ���	#FFC28DAB���	#FFAB648C$��11(�6�   ��59   &   �� 5:   *   " ��60   .�5;   .   ��  � y�$ 	Collapsed=�6K    5<   .   �� 5=   2    6>   �� *	status_id+ 16\   .a�5>   6   ��  � y�$ Visible=�6S   5?   3   5A   +   5C   #   �� 5F   "   $ 
 CompletedAppointmentButton��6)   -   5        $%��Запись завершена��5F   M   ���	#FF6F6F6F$	��5,0q�6   ���	#FFA1A1A1���	#FF6F6F6F$��11(�6�   $��Center=�6�   ��5G   &   �� 5H   *   " ��60   .�5I   .   ��  � y�$ 	Collapsed=�6K    5J   .   �� 5K   2    6>   �� *	status_id+ 26\   .a�5L   6   ��  � y�$ Visible=�6S   5M   3   5O   +   5Q   #   5R      5S      5T      5V      �� 5X      -   5        $
 LogOutButton��5X      ���	#FFB20505$��11(�6B   $&�� Выйти из аккаунта��6P   $��10q�6l   ���	#FF8104046�   5Y      �� 5\   
   $��1��6   $��5��6'   $��Stretch=�61   
�������6O   �� 5^   
   $��2��6   $��10q�6'   $
��Auto=�63   $��Disabled=�6V   .��5`      � $��2��6   $��10q�6#    � RowDefinitions 5a      �� 5b      $
��Auto �6$   �� 5c      $
��Auto �6$   �� 5d      $
��171* �6$   �� 5e      $	��56* �6$   �� 5f      $	��56* �6$   .+�5j      �� $��0��6   $��0,10,0,0q�6*   .+�5k      �� -   5         ��Name$ patientNameTextBlock��5k       $��Пациент:��6>   $
��Bold"�6N   $��14(�6`   �� 5l      -   5        $ serviceNameTextBlock��5l       $��Приём:��6>   $
��Bold"�6L   $��14(�6^   $��0,5,0,10q�6l   5m      �� 5p      $��0,20,0,0q�6   $��1��6/   .+�5q      �� -   5        $��	Complaint��5q      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Жалобы��6U   $	��0,5q�6}   {�6/   �� *IsSessionActive+6}   �� 5r      -	   5        $��	Diagnosis��5r      $ Диагноз��6U   $	��0,5q�6~   {�6/   �� *IsSessionActive+6~   �� 5s      -
   5        $��Notes��5s      $ Заметки��6Q   $	��0,5q�6z   $��50��6�   $��Bottom=�6�   {�6+   �� *IsSessionActive+6�   5t      �� 5u      -   5         ��Name$ IsRecipe��5u   (   $��1��6   $#��Выписать рецепт��6:   $
��auto��6T   $��0,150,10,195q�6a   $��2��6w   6�   �� 5v      -   5         ��Name$ Recipes��5v      $��2��6.   $ Vertical=�6;   $��
0,30,10,10q�6R   .+�5x      �� -   5        $��MedicationName��5x      {�.  $- 'Название медикамента��5y      $	��0,5q�5z      �� 5}      -   5        $��Dosage��5}      {�.  $ Дозировка��5~      $	��0,5q�5      �� 5�      -   5        $��Duration��5�      {�.  $+ %Длительность приема��5�      $	��0,5q�5�      �� 5�      -   5        $��Comments��5�      {�.  $ Комментарий��5�      $	��0,5q�5�      $��45��6   $��Bottom=�6'    �� TextWrapping$
 Wrap=�6I   5�      �� 5�      -   5        $ MaterialsSection��5�      $��3��67   $��	0,10,0,32q�6D   .+�5�      �� $��Материалы:��6    $
��Bold"�62   $��14(�6D   $��0,0,0,5q�6R   �� 5�      -   5         ��Name$ MaterialsListView��5�       �� SelectionMode$ Multiple=�6:   $
��auto��6S   $	��200��6`   ��5�      �� 5�      .R�5�   "   �� $ 
Horizontal=�6-   $��3q�6F   .+�5�   &   �� $	��600��6v   $��5,0,10,0q�6�   ��6/   �� *Name+ d� 	IsChecked 6H   �� *
IsSelected+ �� Mode$ TwoWay=�6�   �� 5�   &   $��50��6U   $��0,0,5,0q�6`   $��Center=�6q   ��6.   �� *
Quantity+$ TwoWay=�.��6�   ��5�   *   �� 5�   .   " ��64   .�5�   2   ��  � {� 6N   �� *
IsSelected+5�   /   .��5�   9   5�   '   5�   #   5�      5�      5�      �� 5�      $ 
Horizontal=�6   $��Center=�66   $��0,7,0,0q�6S   $��4��6d   .+�5�      �� -   5        $#��Завершить прием��5�      ���	#FF0A1129���	#FF0A1129$��14(�6f   $	��847��6t   6�   5�      5�      5�      5�      5�      