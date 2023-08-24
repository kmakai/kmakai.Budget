
const editCategoryBtns = document.querySelectorAll('#EditCategoryBtn');

if (editCategoryBtns) {
    editCategoryBtns.forEach(btn => {
        btn.addEventListener('click', () => {
            const categoryId = btn.getAttribute('data-id');
            const categoryName = btn.getAttribute('data-name');

            console.log(categoryId, categoryName)

            document.querySelector('#AddCategoryForm #AddCategory_Id').value = categoryId;
            document.querySelector('#AddCategoryForm #AddCategory_Name').value = categoryName;

        });
    });
};

const deleteCategoryBtns = document.querySelectorAll('#DeleteCategoryBtn');

if (deleteCategoryBtns) {
    deleteCategoryBtns.forEach(btn => {
        btn.addEventListener("click", () => {
            const categoryId = btn.getAttribute('data-id');

            document.querySelector('#DeleteCategoryForm #DeleteCategoryId').value = categoryId;
        })
    });
}

const editTransactionBtns = document.querySelectorAll('#EditTransactionBtn');

if (editTransactionBtns) {
    editTransactionBtns.forEach(btn => {
        btn.addEventListener('click', () => {
            const transactionId = btn.getAttribute('data-id');
            const transactionName = btn.getAttribute('data-name');
            const transactionAmount = btn.getAttribute('data-amount');
            const transactionDate = btn.getAttribute('data-date');
            const transactionType = btn.getAttribute('data-transactionType');
            const transactionCategory = btn.getAttribute('data-category');

            const addTransactionForm = document.querySelector('#AddTransactionForm');
            console.log(transactionId)

            addTransactionForm.querySelector('#AddTransaction_Id').value = transactionId;
            addTransactionForm.querySelector('#AddTransaction_Name').value = transactionName;
            addTransactionForm.querySelector('#AddTransaction_Amount').value = +transactionAmount;
            addTransactionForm.querySelector('#AddTransactionForm-type-input').value = transactionType;
            addTransactionForm.querySelector('#AddTransactionForm-category-input').value = transactionCategory;
            addTransactionForm.querySelector('#AddTransaction_Date').value = new Date(transactionDate).toISOString().substring(0, 10);
            console.log(new Date(transactionDate).toISOString())
        });
    });
}

const addTransactionBtn = document.querySelector('.open-addTransaction');
addTransactionBtn.addEventListener('click', () => {

    const addTransactionForm = document.querySelector('#AddTransactionForm');

    addTransactionForm.querySelector('#AddTransaction_Id').value = 0;
    addTransactionForm.querySelector('#AddTransaction_Name').value = '';
    addTransactionForm.querySelector('#AddTransaction_Amount').value = 0.00;
    addTransactionForm.querySelector('#AddTransactionForm-type-input').value = '';
    addTransactionForm.querySelector('#AddTransactionForm-category-input').value = '';
    addTransactionForm.querySelector('#AddTransaction_Date').value = '';
});

const typeSelect = document.querySelector('#AddTransactionForm-type-input');

typeSelect.addEventListener('change', () => {
    console.log(typeSelect.value, typeSelect.textContent);
    if (typeSelect.value == 1) {
        document.querySelector('#AddTransactionForm-category-input').value = 7;
        document.querySelector('#AddTransactionForm-category-input').classList.add("hidden");
    } else {
        document.querySelector('#AddTransactionForm-category-input').classList.remove("hidden");
        document.querySelector('#AddTransactionForm-category-input').value = '';
    }
});

const deleteTransactionBtns = document.querySelectorAll('#DeleteTransactionBtn');

if (deleteTransactionBtns) {
    deleteTransactionBtns.forEach(btn => {
btn.addEventListener("click", () => {
            const transactionId = btn.getAttribute('data-id');

            document.querySelector('#DeleteTransactionForm #DeleteTransactionId').value = transactionId;
        })
    });
}