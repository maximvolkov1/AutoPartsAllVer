   M S B A M L   `   `   `  ����G  CAutoPartsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AutoPartsApp.PagesAutoPartsApp.Pages  5      #    AutoPartsApp.Pages.SupplyPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:AutoPartsApp.Pages     5        N� 
Background
  ����� N� Title$ 
SupplyPage��5	      .��5      � .+�5   
   �� -   5         ��Name$ SupplyLV��5      $��	0 80 0 40q�6%   $��Stretch=�68    � ContextMenu 5      �� 5      .@�5      m� -   5         m�Name$ 	addSupply��5   :   $'��!Добавить поставку��6   $��15(�6e   $��Copperplate Gothic Bold)�6s   m� 5      -   5        $ 	delSupply��5   9   $%��Удалить поставку��6   $��15(�6d   $��Copperplate Gothic Bold)�6r   m� 5      -   5        $ updateSupply��5   1   $��Обновить��6   $��15(�6b   $��Copperplate Gothic Bold)�6p   m� 5      -   5        $ reportSupply��5   .   $��
Отчет��6   $��15(�6_   $��Copperplate Gothic Bold)�6m   5      ��5      �� 5      .R�5      �  �Name$ MGrid��6    � ColumnDefinitions 5      �� 5      $��0 �6/   �� 5      $��* �6/   �� 5      $��0 �6/   .+�5      �� $��1��6%   $��5q�65   .+�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $
��Id: ��6,   $��15(�68   $��Copperplate Gothic Bold)�6F   �� 5    "   $��15(�6F   $��Copperplate Gothic Bold)�6T   ��6,   �� *
IdSupply+6T   5!      �� 5"      $ 
Horizontal=�6)   .+�5#   "   �� $'��!Код автозапчасти: ��6,   $��15(�6F   $��Copperplate Gothic Bold)�6T   �� 5$   "   $��15(�6H   $��Copperplate Gothic Bold)�6V   ��6,   �� *
IdAutoPart+6V   5%      �� 5&      $ 
Horizontal=�6)   .+�5'   "   �� $#��Код поставщика: ��6,   $��15(�6D   $��Copperplate Gothic Bold)�6R   �� 5(   "   $��15(�6H   $��Copperplate Gothic Bold)�6V   ��6,   �� *
IdProvider+6V   5)      �� 5*      $ 
Horizontal=�6)   .+�5+   "   �� $!��Дата поставки: ��6,   $��15(�6C   $��Copperplate Gothic Bold)�6Q   �� 5,   "   $��15(�6H   $��Copperplate Gothic Bold)�6V   ��6,   �� *
DateSupply+6V   5-      �� 5.      $ 
Horizontal=�6)   .+�5/   "   �� $��Количество: ��6,   $��15(�6@   $��Copperplate Gothic Bold)�6N   �� 50   "   $��15(�6F   $��Copperplate Gothic Bold)�6T   ��6,   �� *
Quantity+6T   51      �� 52      $ 
Horizontal=�6)   .+�53   "   �� $��
Цена: ��6,   $��15(�6:   $��Copperplate Gothic Bold)�6H   �� 54   "   $��15(�6C   $��Copperplate Gothic Bold)�6Q   ��6,   �� *Price+6Q   55      56      �� 57       ��Name$ editSupplyBtn��64   -   5        $��Изменить��57   !   $��30��6g   $��1��6s   $��Right=�6�   $��Center=�6�   $��15(�6�   $��Copperplate Gothic Bold)�6�   
���   ����	#FF7BB8326   58      59      5;      �� 5<   
   -   5        $��backBtn��5<      $��45��66   $��45��6A   $
��Left=�6M   $	��Top=�6h   $��15,0,0,0q�6�   
���������6�   Z� .��5=      �� $��/Pages/iconBack.png��6   5>      �� 5?   
   $��ООО Автоцентр��6   $	��280��6)   $	��Top=�65   $��36(�6M   $��Copperplate Gothic Bold)�6[   $��Center=�6�   �� 5@   
   $	��С:��6   $��20��6   $��30��6)   $��20(�65   $��Copperplate Gothic Bold)�6C   $
��Left=�6h   $	��Top=�6�   $��	15,50,0,0q�6�   �� 5A   
   $��По:��6   $��35��6   $��30��6*   $��20(�66   $��Copperplate Gothic Bold)�6D   $	��Top=�6i   $
��Left=�6�   $��
220,50,0,0q�6�   (  "System.Windows.Controls.DatePicker  5B   
   -   5        $��	СDatepkr��5B      $	��140��6%   $��25��61   $	��Top=�6=   $
��Left=�6U   $��	50,50,0,0q�6p   6�     5C   
   -	   5        	  Name$	 	PoDatepkr��5C      $	��140��6(   $��24��64   $	��Top=�6@   $
��Left=�6X   $��
270,50,0,0q�6s   6�   �� 5D   
   $��Stretch=�6   $��Bottom=�6/   $��40��6J   ���	#FF7BB8325E      5F      5G      