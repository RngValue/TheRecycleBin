bits 64
global _start
section .text
  _start:
    mov       r9, 1
    .looper:
    mov       rax, r9
    mov       rdx, 0
    mov       rbx, 3
    div       rbx
    mov       rcx, 1
    cmp       rdx, 0
    jne       .notfizz
    call      printfizz
    
    .notfizz:
    mov       rax, r9
    mov       rdx, 0
    mov       rbx, 5
    div       rbx
    cmp       rdx, 0
    jne       .notbuzz
    call      printbuzz
    
    .notbuzz:
    cmp       rcx, 0
    je        .fish
    cmp       rdx, 0
    je        .fish
    cmp       r9, 100
    je        .ishyaku
    mov       r10, r9
    call      printnum
    
    .ishyaku:
    cmp       r9, 100
    jne       .fish
    call      printhyaku
    
    .fish:
    call      endline
    add       r9, 1
    cmp       r9, 101
    jnge      .looper
    
    mov       rax, 60
    xor       rdi, rdi
    syscall
  printnum:
    mov       rax, r10
    cmp       r10, 10
    jnge      .less
    mov       rbx, 10
    mov       rdx, 0
    div       rbx
    mov       rax, r10
    sub       rax, rdx
    mov       rbx, 10
    mov       rdx, 0
    div       rbx
    
    .less:
    add       rax, 48
    push      rax
    
    mov       rsi, rsp
    mov       rax, 1
    mov       rdi, 1
    mov       rdx, 1
    syscall
    
    cmp       r10, 10
    jnge      .lessagain
    mov       rax, r10
    mov       rdx, 0
    mov       rbx, 10
    div       rbx
    add       rdx, 48
    push      rdx
    
    mov       rsi, rsp
    mov       rax, 1
    mov       rdi, 1
    mov       rdx, 1
    syscall
    pop       r10
    
    .lessagain:
    pop       r10
    ret
  printfizz:
    mov       rcx, rdx
    mov       rsi, fizz
    mov       rax, 1
    mov       rdi, 1
    mov       rdx, 4
    syscall
    mov       rcx, 0
    ret
  printbuzz:
    mov       rsi, buzz
    mov       rax, 1
    mov       rdi, 1
    mov       rdx, 4
    syscall
    xor       rdx, rdx
    ret
  printhyaku:
    mov       rsi, hyaku
    mov       rax, 1
    mov       rdi, 1
    mov       rdx, 4
    syscall
    ret
  endline:
    mov       rsi, space
    mov       rax, 1
    mov       rdi, 1
    mov       rdx, 1
    syscall
    ret
section   .data
  fizz:       db    "Fizz"
  buzz:       db    "Buzz"
  hyaku:      db    "100"
  space:      db    10
