   M S B A M L   `   `   `  ����G  CAutoPartsApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AutoPartsApp.PagesAutoPartsApp.Pages  5      '    !AutoPartsApp.Pages.SaleSelectPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:AutoPartsApp.Pages     5        N� 
Background
  ����� N� Title$ SaleSelectPage��5	      .��5      � .+�5   
   �� -   5         ��Name$ SalesLV��5      $��	0 80 0 40q�6$   $��Stretch=�67    � ContextMenu 5      �� 5      5      ��5      �� 5      .R�5      �  �Name$ MGrid��6    � ColumnDefinitions 5      �� 5      $��0 �6/   �� 5      $��* �6/   �� 5      $��* �6/   �� 5      $��0 �6/   .+�5      �� $��1��6%   $��5q�65   .+�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $
��Id: ��6,   $��15(�68   $��Copperplate Gothic Bold)�6F   �� 5   "   $��15(�6D   $��Copperplate Gothic Bold)�6R   ��6,   �� *IdSale+6R   5      �� 5      $ 
Horizontal=�6)   .+�5    "   �� $'��!Код автозапчасти: ��6,   $��15(�6F   $��Copperplate Gothic Bold)�6T   �� 5!   "   $��15(�6K   $��Copperplate Gothic Bold)�6Y   ��6,   �� *NameAutoParts+6Y   5"      �� 5#      $ 
Horizontal=�6)   .+�5$   "   �� $��Код продавца: ��6,   $��15(�6B   $��Copperplate Gothic Bold)�6P   �� 5%   "   $��15(�6A   $��Copperplate Gothic Bold)�6O   ��6,   �� *FIO+6O   5&      �� 5'      $ 
Horizontal=�6)   .+�5(   "   �� $��Код клиента: ��6,   $��15(�6A   $��Copperplate Gothic Bold)�6O   �� 5)   "   $��15(�6K   $��Copperplate Gothic Bold)�6Y   ��6,   �� *SurnameClient+6Y   5*      �� 5+      $ 
Horizontal=�6)   .+�5,   "   �� $��Дата заказа: ��6,   $��15(�6A   $��Copperplate Gothic Bold)�6O   �� 5-   "   $��15(�6F   $��Copperplate Gothic Bold)�6T   ��6,   �� *
DateSale+6T   5.      �� 5/      $ 
Horizontal=�6)   .+�50   "   �� $��Количество: ��6,   $��15(�6@   $��Copperplate Gothic Bold)�6N   �� 51   "   $��15(�6F   $��Copperplate Gothic Bold)�6T   ��6,   �� *
Quantity+6T   52      �� 53      $ 
Horizontal=�6)   .+�54   "   �� $��
Цена: ��6,   $��15(�6:   $��Copperplate Gothic Bold)�6H   �� 55   "   $��15(�6C   $��Copperplate Gothic Bold)�6Q   ��6,   �� *Price+6Q   56      �� 57      $ 
Horizontal=�6)   .+�58   "   �� $%��Общая стоимость: ��6,   $��15(�6E   $��Copperplate Gothic Bold)�6S   �� 59   "   $��15(�6G   $��Copperplate Gothic Bold)�6U   ��6,   �� *	TotalCost+6U   5:      5;      5<      5=      5?      �� 5@   
   -   5        $��backBtn��5@      $��45��66   $��45��6A   $
��Left=�6M   $	��Top=�6h   $��15,0,0,0q�6�   
���������6�   Z� .��5A      �� $��/Pages/iconBack.png��6   5B      �� 5C   
   $��ООО Автоцентр��6   $	��280��6)   $	��Top=�65   $��36(�6M   $��Copperplate Gothic Bold)�6[   $��Center=�6�   �� 5D   
   $��Stretch=�6   $��Bottom=�6/   $��40��6J   ���	#FF7BB8325E      5F      5G      