   M S B A M L   `   `   `  ����G  CDentalClinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DentalClinicDentalClinic  5           DentalClinic.MaterialsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:DentalClinic  5        N� Title$  MaterialsPage��5
       N� 
FontFamily$ Ubuntu)�6   .��5      � .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��10q�6.   $	��Top=�6:   .+�5      �� -   5         ��Name$ SearchTextBox��5      $	��200��6-   $��0,0,10,0q�69   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$) #Поиск по названию...��6K   �� 5      $%��Срок годности до:��6   $��Center=�60   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ BestBeforeDatePicker��5      $	��150��67   $��5,0,10,0q�6C   �� 5      -   5        ���#0A1129
�������$%��Применить фильтр��5   =   $	��172��6X   ���	#FF050D3A6~   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ MaterialsDataGrid��5      ���#0A1129   AutoGenerateColumns .  $
��auto��6_   $��10,60,10,129q�6m      
IsReadOnly . 	 � 	Resources	 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader
 �� 
TargetType �� Property �� Value��%  '        �� 5      "
  6   .�5      ��  � ��
 �����63   �� 5       � ��$ Ubuntu)�63   �� 5       � ��$
 Bold"�63   �� 5       � �� �#0A112963   �� 5       � ��$ Center=�6C   �� 5       � ��$ Center=�6A   5      5          Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6Q      
Foreground
 �����1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *material_id+   HeaderStyle 5#      �� 5$      "
  6    .�5%      ��  � ��
 �����6;   �� 5&       � �� �#0A11296;   �� 5'       � ��$
 Bold"�6;   �� 5(       � ��$ 10,10q�68   �� 5)       � ��$ Center=�6K   5*      5,        5-      $) #Название материала��6%   $	 260 6c   
 ����� 6A   �� *material_name+ 5.      �� 5/      "
  6    .�50      ��  � ��
 �����6;   �� 51       � �� �#0A11296;   �� 52       � ��$
 Bold"�6;   �� 53       � ��$ 10,10q�68   �� 54       � ��$ Center=�6K   55      57        58      $, &Количество на складе��6%   $	 150 6i   
 ����� 6C   �� *quantity_in_stock+ 59      �� 5:      "
  6    .�5;      ��  � ��
 �����6;   �� 5<       � �� �#0A11296;   �� 5=       � ��$
 Bold"�6;   �� 5>       � ��$ Center=�6K   �� 5?       � ��$ Center=�6I   5@      5B        5C      $ Срок годности��6%   $	 150 6�   
 ����� 6<   �� *best_before_date+ �� StringFormat$ {0:dd/MM/yyyy}��6�     5D      $ Поставщик��6%   $	 200 6Z   
 ����� 68   �� *supplier_name+6f   5F      �� 5I   
   $ 
Horizontal=�6   $��Right=�6.   $��Bottom=�6J   $��10q�6e   .+�5J      �� -   5        $#��Обновить данные��5J      ���#0A1129
�������$	��150��6W   $��5q�6c   6n   5K      �� 5L   
   $ 
Horizontal=�6   $
��Left=�6.   $��Bottom=�6I   $��10q�6d   .+�5M      �� -   5        $��
Назад��5M      ���	#FFB20505���	#FF810404$	��150��6T   $��5q�6`   6k   5N      5O      5P      