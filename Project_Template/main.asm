
INCLUDE Irvine32.inc
.DATA
instructions byte  "add","sub","neg","div","mul","mov","movzx","movsx"
memory byte "x0","x1","x2","x3","x4","x5","x6","x7","x8","x9","al","ah","bl","bh","cl","ch","dl","dh","ax","bx","cx","dx","eax","ebx","ecx","edx","esi","edi"
x0 byte 1
x1 byte 1
x2 byte 1
x3 byte 1
x4 byte 1
x5 byte 1
x6 byte 1
x7 byte 1
x8 byte 1
x9 byte 1
sentence byte 30 dup (?)
inss byte 20 dup (?)
operand1 byte 20 dup (?)
operand2 byte 20 dup (?)
counter1 byte ?
counter2 byte 0
inssletters byte 0
operand1letters byte 0
operand2letters byte 0
insnum byte ?
operand1num byte ?
operand2num byte ?
operand1size byte ?
operand2size byte ?
checkforret byte 1

.code

main PROC
start:
call initializing
mov edx,offset sentence
mov ecx,30
call readstring

cmp eax,3
jne notret
mov edx,offset sentence
call checkRet
cmp checkforret,0
je endofprogram

notret:

mov edx,offset sentence
mov ebx,offset inss
call findInstruction


mov ebx,offset operand1
call findOperand1

mov ebx,offset operand2
call findOperand2

mov edx,offset inss
mov ecx,20
call countinsnum

mov edx,offset operand1
mov ecx,20
call countoperand1num

mov edx,offset operand2
mov ecx,20
call countoperand2num



mov edx,offset instructions
cmp inssletters,3
jne retry1
mov ecx,6
call compareInstruction1
jmp finish1

retry1:
cmp inssletters,5
jne goout1
mov ecx,2
add edx,18
call compareInstruction2
jmp finish1

goout1:
mov insnum,0


finish1:

mov counter2,0

mov edx,offset memory
cmp operand1letters,2
jne retry2
mov ecx,22
call compareOperand11
jmp finish2

retry2:
cmp operand1letters,3
jne goout2
mov ecx,6
add edx,44
call compareOperand12
jmp finish2

goout2:
mov operand1num,0


finish2:

mov counter2,0

mov edx,offset memory
cmp operand2letters,2
jne retry3
mov ecx,22
call compareOperand21
jmp finish3

retry3:
cmp operand2letters,3
jne goout3
mov ecx,6
add edx,44
call compareOperand22
jmp finish3

goout3:
mov operand2num,0


finish3:
call calculatinginstruction

;testing
mov al,x0
call writedec
call crlf
mov al,insnum
call writedec
call crlf
mov al,operand1num
call writedec
call crlf
mov al,operand1size
call writedec
call crlf
mov al,operand2num
call writedec
call crlf
mov al,operand2size
call writedec
call crlf
mov edx,offset sentence
call clearingSentence
mov edx,offset inss
call clearing
mov edx,offset operand1
call clearing
mov edx,offset operand2
call clearing


jmp start
;testing

endofprogram:

	exit
main ENDP


findInstruction PROC
l1:
mov al,' '
cmp [edx],al
je l2
mov al,[edx]
mov [ebx],al
inc edx
inc ebx
jmp l1
l2:
ret
findInstruction ENDP


findOperand1 PROC
mov al,' '
l2:
inc edx
cmp [edx],al
je l2
l1:
mov al,[edx]
mov [ebx],al
inc edx
inc ebx
l5:
mov al,' '
cmp [edx],al
je l4
mov al,','
cmp [edx],al
je l3
jmp l1
l4:
inc edx
jmp l5
l3:
ret
findOperand1 ENDP



findOperand2 PROC
mov al,' '
l2:
inc edx
cmp [edx],al
je l2
l1:
mov al,[edx]
mov [ebx],al
inc edx
inc ebx
mov al,' '
cmp [edx],al
je l3
mov al,0
cmp [edx],al
je l3
jmp l1
l3:
ret
findOperand2 ENDP


compareInstruction1 PROC

L1:
mov ebx,offset inss
mov counter1,cl
mov cl,inssletters
L2:
mov al,[ebx]
cmp [edx],al
jne continue1
inc edx
inc ebx
cmp ecx,1
je equal1


loop L2
continue1:
mov cl,counter1
mov edx,offset instructions
add counter2,3
add dl,counter2
cmp ecx,1
je notfound
loop L1


notfound:
mov insnum,0
ret
equal1:
mov al,counter1
mov insnum,al
add insnum,2
ret

compareInstruction1 ENDP



compareInstruction2 PROC


L1:
mov ebx,offset inss
mov counter1,cl
mov cl,inssletters
L2:
mov al,[ebx]
cmp [edx],al
jne continue1
inc edx
inc ebx
cmp ecx,1
je equal1


loop L2
continue1:
mov cl,counter1
mov edx,offset instructions
add edx, 23
cmp ecx,1
je notfound
loop L1


notfound:
mov insnum,0
ret
equal1:
mov al,counter1
mov insnum,al
ret


compareInstruction2 ENDP



compareOperand11 PROC

L1:
mov ebx,offset operand1
mov counter1,cl
mov cl,operand1letters
L2:
mov al,[ebx]
cmp [edx],al
jne continue1
inc edx
inc ebx
cmp ecx,1
je equal1


loop L2
continue1:
mov cl,counter1
mov edx,offset memory
add counter2,2
add dl,counter2
cmp ecx,1
je notfound
loop L1


notfound:
mov operand1num,0
ret
equal1:
mov al,counter1
mov operand1num,al
add operand1num,6
mov al,10
cmp operand1num,al
ja above
mov operand1size,2
ret

above:
mov operand1size,1
ret
compareOperand11 ENDP


compareOperand12 PROC

L1:
mov ebx,offset operand1
mov counter1,cl
mov cl,operand1letters
L2:
mov al,[ebx]
cmp [edx],al
jne continue1
inc edx
inc ebx
cmp ecx,1
je equal1


loop L2
continue1:
mov cl,counter1
mov edx,offset memory
add edx,44
add counter2,3
add dl,counter2
cmp ecx,1
je notfound
loop L1


notfound:
mov operand1num,0
ret
equal1:
mov al,counter1
mov operand1num,al

mov operand1size,3
ret
compareOperand12 ENDP





compareOperand21 PROC

L1:
mov ebx,offset operand2
mov counter1,cl
mov cl,operand2letters
L2:
mov al,[ebx]
cmp [edx],al
jne continue1
inc edx
inc ebx
cmp ecx,1
je equal1


loop L2
continue1:
mov cl,counter1
mov edx,offset memory
add counter2,2
add dl,counter2
cmp ecx,1
je notfound
loop L1


notfound:
mov operand2num,0
ret
equal1:
mov al,counter1
mov operand2num,al
add operand2num,6
mov al,10
cmp operand2num,al
ja above
mov operand2size,2
ret

above:
mov operand2size,1
ret
compareOperand21 ENDP


compareOperand22 PROC

L1:
mov ebx,offset operand2
mov counter1,cl
mov cl,operand2letters
L2:
mov al,[ebx]
cmp [edx],al
jne continue1
inc edx
inc ebx
cmp ecx,1
je equal1


loop L2
continue1:
mov cl,counter1
mov edx,offset memory
add edx,44
add counter2,3
add dl,counter2
cmp ecx,1
je notfound
loop L1


notfound:
mov operand1num,0
ret
equal1:
mov al,counter1
mov operand2num,al

mov operand2size,3
ret
compareOperand22 ENDP




countinsnum PROC
L1:
mov al,[edx]
cmp al,0
je goout
inc edx
inc inssletters
loop L1


goout:
ret
countinsnum ENDP



countoperand1num PROC
L1:
mov al,[edx]
cmp al,0
je goout
inc edx
inc operand1letters
loop L1


goout:
ret
countoperand1num ENDP

countoperand2num PROC
L1:
mov al,[edx]
cmp al,0
je goout
inc edx
inc operand2letters
loop L1


goout:
ret
countoperand2num ENDP


calculatinginstruction PROC
cmp insnum,8
je addinstruction

calculatinginstruction ENDP


addinstruction PROC


cmp operand1num,28
je first28

cmp operand1num,27
je first27

cmp operand1num,26
je first26

cmp operand1num,25
je first25



first28:


cmp operand2num,18
je finish2818

cmp operand2num,17
je finish2817

cmp operand2num,16
je finish2816

cmp operand2num,15
je finish2815

cmp operand2num,14
je finish2814

cmp operand2num,13
je finish2813

cmp operand2num,12
je finish2812

cmp operand2num,11
je finish2811



jmp goout










finish2818:
call initializing
add x0,al
ret
finish2817:
call initializing
add x0,ah
ret
finish2816:
call initializing
add x0,bl
ret
finish2815:
call initializing
add x0,bh
ret
finish2814:
call initializing
add x0,cl
ret
finish2813:
call initializing
add x0,ch
ret
finish2812:
call initializing
add x0,dl
ret
finish2811:
call initializing
add x0,dh
ret




first27:


cmp operand2num,18
je finish2718

cmp operand2num,17
je finish2717

cmp operand2num,16
je finish2716

cmp operand2num,15
je finish2715

cmp operand2num,14
je finish2714

cmp operand2num,13
je finish2713

cmp operand2num,12
je finish2712

cmp operand2num,11
je finish2711

jmp goout










finish2718:
call initializing
add x1,al
ret
finish2717:
call initializing
add x1,ah
ret
finish2716:
call initializing
add x1,bl
ret
finish2715:
call initializing
add x1,bh
ret
finish2714:
call initializing
add x1,cl
ret
finish2713:
call initializing
add x1,ch
ret
finish2712:
call initializing
add x1,dl
ret
finish2711:
call initializing
add x1,dh
ret


first26:


cmp operand2num,18
je finish2618

cmp operand2num,17
je finish2617

cmp operand2num,16
je finish2616

cmp operand2num,15
je finish2615

cmp operand2num,14
je finish2614

cmp operand2num,13
je finish2613

cmp operand2num,12
je finish2612

cmp operand2num,11
je finish2611

jmp goout










finish2618:
call initializing
add x2,al
ret
finish2617:
call initializing
add x2,ah
ret
finish2616:
call initializing
add x2,bl
ret
finish2615:
call initializing
add x2,bh
ret
finish2614:
call initializing
add x2,cl
ret
finish2613:
call initializing
add x2,ch
ret
finish2612:
call initializing
add x2,dl
ret
finish2611:
call initializing
add x2,dh
ret


first25:


cmp operand2num,18
je finish2518

cmp operand2num,17
je finish2517

cmp operand2num,16
je finish2516

cmp operand2num,15
je finish2515

cmp operand2num,14
je finish2514

cmp operand2num,13
je finish2513

cmp operand2num,12
je finish2512

cmp operand2num,11
je finish2511

jmp goout










finish2518:
call initializing
add x3,al
ret
finish2517:
call initializing
add x3,ah
ret
finish2516:
call initializing
add x3,bl
ret
finish2515:
call initializing
add x3,bh
ret
finish2514:
call initializing
add x3,cl
ret
finish2513:
call initializing
add x3,ch
ret
finish2512:
call initializing
add x3,dl
ret
finish2511:
call initializing
add x3,dh
ret

first24:


cmp operand2num,18
je finish2418

cmp operand2num,17
je finish2417

cmp operand2num,16
je finish2416

cmp operand2num,15
je finish2415

cmp operand2num,14
je finish2414

cmp operand2num,13
je finish2413

cmp operand2num,12
je finish2412

cmp operand2num,11
je finish2411

jmp goout










finish2418:
call initializing
add x4,al
ret
finish2417:
call initializing
add x4,ah
ret
finish2416:
call initializing
add x4,bl
ret
finish2415:
call initializing
add x4,bh
ret
finish2414:
call initializing
add x4,cl
ret
finish2413:
call initializing
add x4,ch
ret
finish2412:
call initializing
add x4,dl
ret
finish2411:
call initializing
add x4,dh
ret

first23:


cmp operand2num,18
je finish2318

cmp operand2num,17
je finish2317

cmp operand2num,16
je finish2316

cmp operand2num,15
je finish2315

cmp operand2num,14
je finish2314

cmp operand2num,13
je finish2313

cmp operand2num,12
je finish2312

cmp operand2num,11
je finish2311

jmp goout










finish2318:
call initializing
add x5,al
ret
finish2317:
call initializing
add x5,ah
ret
finish2316:
call initializing
add x5,bl
ret
finish2315:
call initializing
add x5,bh
ret
finish2314:
call initializing
add x5,cl
ret
finish2313:
call initializing
add x5,ch
ret
finish2312:
call initializing
add x5,dl
ret
finish2311:
call initializing
add x5,dh
ret

first22:


cmp operand2num,18
je finish2218

cmp operand2num,17
je finish2217

cmp operand2num,16
je finish2216

cmp operand2num,15
je finish2215

cmp operand2num,14
je finish2214

cmp operand2num,13
je finish2213

cmp operand2num,12
je finish2212

cmp operand2num,11
je finish2211

jmp goout










finish2218:
call initializing
add x6,al
ret
finish2217:
call initializing
add x6,ah
ret
finish2216:
call initializing
add x6,bl
ret
finish2215:
call initializing
add x6,bh
ret
finish2214:
call initializing
add x6,cl
ret
finish2213:
call initializing
add x6,ch
ret
finish2212:
call initializing
add x6,dl
ret
finish2211:
call initializing
add x6,dh
ret


first21:


cmp operand2num,18
je finish2118

cmp operand2num,17
je finish2117

cmp operand2num,16
je finish2116

cmp operand2num,15
je finish2115

cmp operand2num,14
je finish2114

cmp operand2num,13
je finish2113

cmp operand2num,12
je finish2112

cmp operand2num,11
je finish2111

jmp goout










finish2118:
call initializing
add x7,al
ret
finish2117:
call initializing
add x7,ah
ret
finish2116:
call initializing
add x7,bl
ret
finish2115:
call initializing
add x7,bh
ret
finish2114:
call initializing
add x7,cl
ret
finish2113:
call initializing
add x7,ch
ret
finish2112:
call initializing
add x7,dl
ret
finish2111:
call initializing
add x7,dh
ret


first20:


cmp operand2num,18
je finish2018

cmp operand2num,17
je finish2017

cmp operand2num,16
je finish2016

cmp operand2num,15
je finish2015

cmp operand2num,14
je finish2014

cmp operand2num,13
je finish2013

cmp operand2num,12
je finish2012

cmp operand2num,11
je finish2011

jmp goout










finish2018:
call initializing
add x8,al
ret
finish2017:
call initializing
add x8,ah
ret
finish2016:
call initializing
add x8,bl
ret
finish2015:
call initializing
add x8,bh
ret
finish2014:
call initializing
add x8,cl
ret
finish2013:
call initializing
add x8,ch
ret
finish2012:
call initializing
add x8,dl
ret
finish2011:
call initializing
add x8,dh
ret


first19:


cmp operand2num,18
je finish1918

cmp operand2num,17
je finish1917

cmp operand2num,16
je finish1916

cmp operand2num,15
je finish1915

cmp operand2num,14
je finish1914

cmp operand2num,13
je finish1913

cmp operand2num,12
je finish1912

cmp operand2num,11
je finish1911

jmp goout










finish1918:
call initializing
add x9,al
ret
finish1917:
call initializing
add x9,ah
ret
finish1916:
call initializing
add x9,bl
ret
finish1915:
call initializing
add x9,bh
ret
finish1914:
call initializing
add x9,cl
ret
finish1913:
call initializing
add x9,ch
ret
finish1912:
call initializing
add x9,dl
ret
finish1911:
call initializing
add x9,dh
ret



first18:

cmp operand2num,28
je finish1828

cmp operand2num,27
je finish1827

cmp operand2num,26
je finish1826

cmp operand2num,25
je finish1825

cmp operand2num,24
je finish1824

cmp operand2num,23
je finish1823

cmp operand2num,22
je finish1822

cmp operand2num,21
je finish1821

cmp operand2num,20
je finish1820

cmp operand2num,19
je finish1819


cmp operand2num,17
je finish1817

cmp operand2num,16
je finish1816

cmp operand2num,15
je finish1815

cmp operand2num,14
je finish1814

cmp operand2num,13
je finish1813

cmp operand2num,12
je finish1812

cmp operand2num,11
je finish1811

jmp goout








finish1828:
call initializing
add al,x0
ret
finish1827:
call initializing
add al,x1
ret
finish1826:
call initializing
add al,x2
ret
finish1825:
call initializing
add al,x3
ret
finish1824:
call initializing
add al,x4
ret
finish1823:
call initializing
add al,x5
ret
finish1822:
call initializing
add al,x6
ret
finish1821:
call initializing
add al,x7
ret

finish1820:
call initializing
add al,x8
ret

finish1819:
call initializing
add al,x9
ret

finish1817:
call initializing
add al,ah
ret
finish1816:
call initializing
add al,bl
ret
finish1815:
call initializing
add al,bh
ret
finish1814:
call initializing
add al,cl
ret
finish1813:
call initializing
add al,ch
ret
finish1812:
call initializing
add al,dl
ret
finish1811:
call initializing
add al,dh
ret




first17:

cmp operand2num,28
je finish1728

cmp operand2num,27
je finish1727

cmp operand2num,26
je finish1726

cmp operand2num,25
je finish1725

cmp operand2num,24
je finish1724

cmp operand2num,23
je finish1723

cmp operand2num,22
je finish1722

cmp operand2num,21
je finish1721

cmp operand2num,20
je finish1720

cmp operand2num,19
je finish1719


cmp operand2num,18
je finish1718

cmp operand2num,16
je finish1716

cmp operand2num,15
je finish1715

cmp operand2num,14
je finish1714

cmp operand2num,13
je finish1713

cmp operand2num,12
je finish1712

cmp operand2num,11
je finish1711

jmp goout








finish1728:
call initializing
add ah,x0
ret
finish1727:
call initializing
add ah,x1
ret
finish1726:
call initializing
add ah,x2
ret
finish1725:
call initializing
add ah,x3
ret
finish1724:
call initializing
add ah,x4
ret
finish1723:
call initializing
add ah,x5
ret
finish1722:
call initializing
add ah,x6
ret
finish1721:
call initializing
add ah,x7
ret

finish1720:
call initializing
add ah,x8
ret

finish1719:
call initializing
add ah,x9
ret

finish1718:
call initializing
add ah,al
ret
finish1716:
call initializing
add ah,bl
ret
finish1715:
call initializing
add ah,bh
ret
finish1714:
call initializing
add ah,cl
ret
finish1713:
call initializing
add ah,ch
ret
finish1712:
call initializing
add ah,dl
ret
finish1711:
call initializing
add ah,dh
ret



first16:

cmp operand2num,28
je finish1628

cmp operand2num,27
je finish1627

cmp operand2num,26
je finish1626

cmp operand2num,25
je finish1625

cmp operand2num,24
je finish1624

cmp operand2num,23
je finish1623

cmp operand2num,22
je finish1622

cmp operand2num,21
je finish1621

cmp operand2num,20
je finish1620

cmp operand2num,19
je finish1619

cmp operand2num,18
je finish1618

cmp operand2num,17
je finish1617

cmp operand2num,15
je finish1615

cmp operand2num,14
je finish1614

cmp operand2num,13
je finish1613

cmp operand2num,12
je finish1612

cmp operand2num,11
je finish1611

jmp goout





finish1628:
call initializing
add ah,x0
ret
finish1627:
call initializing
add ah,x1
ret
finish1626:
call initializing
add ah,x2
ret
finish1625:
call initializing
add ah,x3
ret
finish1624:
call initializing
add ah,x4
ret
finish1623:
call initializing
add ah,x5
ret
finish1622:
call initializing
add ah,x6
ret
finish1621:
call initializing
add ah,x7
ret
finish1620:
call initializing
add ah,x8
ret
finish1619:
call initializing
add ah,x9
ret
finish1618:
call initializing
add bl,al
ret
finish1617:
call initializing
add bl,ah
ret
finish1615:
call initializing
add bl,bh
ret
finish1614:
call initializing
add bl,cl
ret
finish1613:
call initializing
add bl,ch
ret
finish1612:
call initializing
add bl,dl
ret
finish1611:
call initializing
add bl,dh
ret
\





goout:
ret













addinstruction ENDP



checkRet PROC
mov al,[edx]
cmp al,'r'
je continue1
ret

continue1:
inc edx
mov al,[edx]
cmp al,'e'
je continue2
ret

continue2:
inc edx
mov al,[edx]
cmp al,'t'
je continue3
ret

continue3:
mov checkforret,0
ret





checkRet ENDP


clearingSentence PROC
mov al,0
mov ecx,30
L1:
mov [edx],al
inc edx
loop L1
ret
clearingSentence ENDP

clearing PROC
mov al,0
mov ecx,20
L1:
mov [edx],al
inc edx
loop L1
ret
clearing ENDP

initializing PROC
mov eax,1
mov ebx,1
mov ecx,1
mov edx,1
mov esi,1
mov edi,1
mov ebp,1
mov counter2,0
mov inssletters,0
mov operand1letters,0
mov operand2letters,0
ret
initializing ENDP


END main