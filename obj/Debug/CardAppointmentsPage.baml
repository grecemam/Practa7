   M S B A M L   `   `   `  ����G  CDentalClinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DentalClinicDentalClinic  5      '    !DentalClinic.CardAppointmentsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      &localclr-namespace:DentalClinic  5        N� 
FontFamily$  Bahnschrift)�5	   1    � Language$ ru-RU�6J    N� Title$ CardAppointmentsPage��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      $	��400 �6   .+�5   
   �� -   5         ��Name$ AppointmentsListView��5      $��0��61   $��10q�6A   ��5      �� 5      .R�5      �� 
�������$��1q�60   $��5q�6D    �� CornerRadius$ 5��6O   ���#F9F9F9$	��300��6u   $��Center=�6�   ._�5      �� $��10q�6%   .+�5      ��  �� TextAlignment$ Center=�6F   $
��Bold"�6]   $��14(�6o   
���   ���6(   �� *service_name+6}   �� 5      $ Center=�6E   $��12(�6\   
�������$��0,5,0,0q�6|   ��6(   �� *doctor_name+6|   �� 5      $ Center=�6m   $��12(�6�   
���������6(   �� *appointment_date+ �� StringFormat$ {0:dd MMMM yyyy}��6�   �� 5      $ Center=�6f   $��12(�6}   
���������6(   �� *appointment_time+$ 	{0:HH:mm}��6�   5      5      5       5"      �� 5%   
   $��1��6   $��
10,10,0,10q�6%   .+�5&      �� -   5        $��NameAppoinment��5&      $��SemiBold"�6.   $��16(�6D   $��0,0,0,10q�6R   �� 5(       �� Orientation$ 
Horizontal=�6   .+�5)      �� $��	Врач:��6   $��Medium"�6)   �� 5*      -   5        $��	DoctorTxb��5*      $��5,0,0,0q�6-   5+      �� 5-      $ 
Horizontal=�6   $��0,10,0,0q�62   .+�5.      �� $��	Дата:��6   $��Medium"�6)   �� 5/      -   5        $��AppointmentDateTextBlock��5/      $��5,0,0,0q�6<   50      �� 52      $ 
Horizontal=�6   $��0,10,0,0q�62   .+�53      �� $��Время:��6   $��Medium"�6*   �� 54      -   5        $��AppointmentTimeTextBlock��54      $��5,0,0,0q�6<   55      �� 57      $ 
Horizontal=�6   $��0,10,0,0q�62   .+�58      �� $��Диагноз:��6   $��Medium"�6,   �� 59      -   5        $��DiagnosisTextBlock��59      $
��Wrap=�66   $��5,0,0,10q�6J   5:      �� 5<      -   5        	 ��Name$	 
RecipesTxb��5<      $��Назначения:��6,   $��Medium"�6?   $��0,10,0,0q�6S   �� 5=      -   5        $��PrescriptionsListView��5=      $	��100��64   $��0,0,0,10q�6A   ��5>      �� 5?      .R�5@      �� .+�5A      �� $
��Bold"�6D   ��6(   �� *
Medication+6D   �� 5B      $��12(�6@   
���������6(   �� *Dosage+6N   �� 5C      $��12(�6B   
���������6(   �� *
Duration+6P   �� 5D      $��12(�6B   
���������6(   �� *
Comments+6P   5E      5F      5H      5I      5J      5L      